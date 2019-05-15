namespace DuplicateLineFinder
{
    partial class LineFinderForm
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
            this.locationBox = new System.Windows.Forms.TextBox();
            this.locationBrowseButton = new System.Windows.Forms.Button();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Location";
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.Location = new System.Drawing.Point(12, 25);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(212, 20);
            this.locationBox.TabIndex = 1;
            // 
            // locationBrowseButton
            // 
            this.locationBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBrowseButton.Location = new System.Drawing.Point(230, 25);
            this.locationBrowseButton.Name = "locationBrowseButton";
            this.locationBrowseButton.Size = new System.Drawing.Size(40, 20);
            this.locationBrowseButton.TabIndex = 2;
            this.locationBrowseButton.Text = "...";
            this.locationBrowseButton.UseVisualStyleBackColor = true;
            this.locationBrowseButton.Click += new System.EventHandler(this.LocationBrowseButton_Click);
            // 
            // actionBox
            // 
            this.actionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Items.AddRange(new object[] {
            "Just Show",
            "Just Remove",
            "Show and Remove"});
            this.actionBox.Location = new System.Drawing.Point(12, 64);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(258, 21);
            this.actionBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Action";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(12, 126);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(260, 23);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Find!";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // LineFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.locationBrowseButton);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LineFinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicate Line Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Button locationBrowseButton;
        private System.Windows.Forms.ComboBox actionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
    }
}

