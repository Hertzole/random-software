using Ookii.Dialogs.WinForms;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifySongMatcher
{
    public partial class Form1 : Form
    {
        private const string PLAYLIST_REGEX = "https:\\/\\/open.spotify.com\\/user\\/([A-z0-9]*)\\/playlist\\/([A-z0-9]*)\\?si=[A-z0-9]*";

        private SpotifyWebAPI spotify;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Get credentials.
            CredentialsAuth auth = new CredentialsAuth("", "");
            Token token = await auth.GetToken();

            spotify = new SpotifyWebAPI
            {
                AccessToken = token.AccessToken,
                TokenType = token.TokenType
            };

            ValidateMatchButton();
        }

        private void playlistBox_TextChanged(object sender, EventArgs e)
        {
            ValidateMatchButton();
        }

        private void songsBox_TextChanged(object sender, EventArgs e)
        {
            ValidateMatchButton();
        }

        private void ValidateMatchButton()
        {
            matchButton.Enabled = !string.IsNullOrWhiteSpace(playlistBox.Text) && !string.IsNullOrEmpty(songsBox.Text);
        }

        private void songsBrowseButton_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog()
            {
                UseDescriptionForTitle = true,
                Description = "Select songs location"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                songsBox.Text = dialog.SelectedPath;
            }
        }

        private async void matchButton_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(songsBox.Text, "*.mp3");
            if (files != null && files.Length > 0)
            {
                string userId = string.Empty;
                string playlistId = string.Empty;

                Regex regex = new Regex(PLAYLIST_REGEX);
                Match matches = regex.Match(playlistBox.Text);

                if (matches == null || matches.Groups.Count == 0 || matches.Groups.Count != 3)
                {
                    MessageBox.Show("Not a valid playlist link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                userId = matches.Groups[1].Value;
                playlistId = matches.Groups[2].Value;

                List<PlaylistTrack> allTracks = new List<PlaylistTrack>();
                List<string> skippedFiles = new List<string>();

                await GetTracksRecursive(allTracks, userId, playlistId, 0);

                string fileName = string.Empty;
                string file = string.Empty;
                FullTrack targetTrack = null;
                string newFileName = string.Empty;
                List<string> artists = new List<string>();
                List<int> alreadyUsedTracks = new List<int>();

                for (int i = 0; i < files.Length; i++)
                {
                    try
                    {
                        file = files[i];

                        TagLib.File tags = TagLib.File.Create(files[i]);

                        if (!string.IsNullOrWhiteSpace(tags.Tag.Title))
                            continue;

                        fileName = Path.GetFileNameWithoutExtension(files[i]).ToLower();
                        targetTrack = null;
                        if (fileName.Contains("lyrics"))
                            fileName = fileName.Remove(fileName.IndexOf("lyrics"), "lyrics".Length);
                        if (fileName.Contains("lyric"))
                            fileName = fileName.Remove(fileName.IndexOf("lyric"), "lyric".Length);
                        if (fileName.Contains("official audio"))
                            fileName = fileName.Remove(fileName.IndexOf("official audio"), "official audio".Length);
                        if (fileName.Contains("audio"))
                            fileName = fileName.Remove(fileName.IndexOf("audio"), "audio".Length);

                        fileName = fileName.Replace("-", "").Replace("'", "").Replace(",", "");

                        for (int t = 0; t < allTracks.Count; t++)
                        {
                            string trackName = allTracks[t].Track.Name.ToLower().Replace("-", "").Replace("'", "").Replace(",", "");

                            if ((trackName.Contains(fileName) || fileName.Contains(trackName.ToLower())) && !alreadyUsedTracks.Contains(t))
                            {
                                alreadyUsedTracks.Add(t);
                                targetTrack = allTracks[t].Track;
                            }
                        }

                        if (targetTrack == null)
                        {
                            skippedFiles.Add(Path.GetFileNameWithoutExtension(files[i]));
                            continue;
                        }

                        artists.Clear();
                        for (int a = 0; a < targetTrack.Artists.Count; a++)
                            artists.Add(targetTrack.Artists[a].Name);

                        tags.Tag.Title = targetTrack.Name;
                        tags.Tag.Album = targetTrack.Album.Name;
                        tags.Tag.AlbumArtists = artists.ToArray();
                        tags.Tag.Performers = artists.ToArray();

                        tags.Save();

                        newFileName = (Path.GetDirectoryName(files[i]) + "/" + targetTrack.Name + ".mp3").Replace("?", "");

                        if (file != newFileName)
                            File.Move(file, newFileName);


                    }
                    catch (IOException)
                    {
                        MessageBox.Show(file, "Failed to move", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (skippedFiles.Count > 0)
                {
                    StringBuilder sb = new StringBuilder("Skipped " + skippedFiles.Count + " songs:\n");
                    for (int i = 0; i < skippedFiles.Count; i++)
                    {
                        sb.AppendLine(skippedFiles[i]);
                    }

                    MessageBox.Show(sb.ToString(), "Skipped Files", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("All songs have been named!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("There were no valid songs in that directory.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task GetTracksRecursive(List<PlaylistTrack> allTracks, string userId, string playlistId, int offset)
        {
            Paging<PlaylistTrack> playlist = await spotify.GetPlaylistTracksAsync(userId, playlistId, offset: offset * 100);
            allTracks.AddRange(playlist.Items);
            if (playlist.HasNextPage())
            {
                await GetTracksRecursive(allTracks, userId, playlistId, offset + 1);
            }
        }
    }
}
