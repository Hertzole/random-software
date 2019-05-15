using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DuplicateLineFinder
{
    public partial class LineFinderForm : Form
    {
        private DuplicatesForm duplicateForm;

        public LineFinderForm()
        {
            InitializeComponent();

            // Create the form.
            duplicateForm = new DuplicatesForm();

            // Make sure something is selected.
            actionBox.SelectedIndex = 0;

            // Validate the find button.
            ValidateFindButton();
        }

        private void LocationBrowseButton_Click(object sender, EventArgs e)
        {
            // Open a file dialog.
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    locationBox.Text = dialog.FileName;
                }
            }

            // Validate the find button afterwards since the location box
            // most likely changed.
            ValidateFindButton();
        }

        private void ValidateFindButton()
        {
            // Only enable if there's a location.
            findButton.Enabled = !string.IsNullOrEmpty(locationBox.Text);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(locationBox.Text))
            {
                string[] lines = File.ReadAllLines(locationBox.Text);
                List<int> duplicateLinesIndex = new List<int>();

                for (int i = 0; i < lines.Length; i++)
                {
                    for (int n = 0; n < lines.Length; n++)
                    {
                        // Make sure we aren't on the same line,
                        // check if the text on the line is the same,
                        // check so the line index isn't already added, and
                        // check that i is above n so it doesn't add the original.
                        if (i != n && lines[i] == lines[n] && !duplicateLinesIndex.Contains(i) && i > n)
                        {
                            duplicateLinesIndex.Add(i);
                        }
                    }
                }

                string[] duplicateLines = new string[duplicateLinesIndex.Count];

                // Just add the duplicate lines into the array.
                for (int i = 0; i < duplicateLinesIndex.Count; i++)
                {
                    duplicateLines[i] = lines[duplicateLinesIndex[i]];
                }

                if (duplicateLines.Length > 0)
                {
                    if (actionBox.SelectedIndex == 0 || actionBox.SelectedIndex == 2)
                    {
                        duplicateForm.ShowDialog(duplicateLinesIndex, duplicateLines);
                    }

                    if (actionBox.SelectedIndex == 1 || actionBox.SelectedIndex == 2)
                    {
                        List<string> linesFixed = new List<string>(lines);

                        // Reverse loop so we start at the bottom.
                        for (int i = linesFixed.Count - 1; i >= 0; i--)
                        {
                            for (int n = 0; n < duplicateLinesIndex.Count; n++)
                            {
                                // Remove the line if there's a matching line index at n.
                                if (i == duplicateLinesIndex[n])
                                {
                                    linesFixed.RemoveAt(i);
                                }
                            }
                        }

                        if (File.Exists(locationBox.Text))
                            File.WriteAllLines(locationBox.Text, linesFixed);
                        else
                            MessageBox.Show("Updating the file failed because it has been moved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Found no duplicates.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The file at that location does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
