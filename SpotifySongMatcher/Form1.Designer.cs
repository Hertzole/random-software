namespace SpotifySongMatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.playlistBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.songsBox = new System.Windows.Forms.TextBox();
            this.songsBrowseButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playlist link:";
            // 
            // playlistBox
            // 
            this.playlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistBox.Location = new System.Drawing.Point(92, 6);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(180, 20);
            this.playlistBox.TabIndex = 1;
            this.playlistBox.TextChanged += new System.EventHandler(this.playlistBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Songs location:";
            // 
            // songsBox
            // 
            this.songsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.songsBox.Location = new System.Drawing.Point(92, 32);
            this.songsBox.Name = "songsBox";
            this.songsBox.Size = new System.Drawing.Size(134, 20);
            this.songsBox.TabIndex = 3;
            this.songsBox.TextChanged += new System.EventHandler(this.songsBox_TextChanged);
            // 
            // songsBrowseButton
            // 
            this.songsBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.songsBrowseButton.Location = new System.Drawing.Point(232, 30);
            this.songsBrowseButton.Name = "songsBrowseButton";
            this.songsBrowseButton.Size = new System.Drawing.Size(40, 23);
            this.songsBrowseButton.TabIndex = 4;
            this.songsBrowseButton.Text = "...";
            this.songsBrowseButton.UseVisualStyleBackColor = true;
            this.songsBrowseButton.Click += new System.EventHandler(this.songsBrowseButton_Click);
            // 
            // matchButton
            // 
            this.matchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchButton.Location = new System.Drawing.Point(12, 86);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(260, 23);
            this.matchButton.TabIndex = 5;
            this.matchButton.Text = "Match!";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.songsBrowseButton);
            this.Controls.Add(this.songsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Spotify Song Matcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playlistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox songsBox;
        private System.Windows.Forms.Button songsBrowseButton;
        private System.Windows.Forms.Button matchButton;
    }
}

