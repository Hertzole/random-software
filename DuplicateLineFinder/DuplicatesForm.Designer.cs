namespace DuplicateLineFinder
{
    partial class DuplicatesForm
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
            this.duplicatesLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.lineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // duplicatesLabel
            // 
            this.duplicatesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.duplicatesLabel.AutoSize = true;
            this.duplicatesLabel.Location = new System.Drawing.Point(12, 9);
            this.duplicatesLabel.Name = "duplicatesLabel";
            this.duplicatesLabel.Size = new System.Drawing.Size(111, 13);
            this.duplicatesLabel.TabIndex = 0;
            this.duplicatesLabel.Text = "Found N/A duplicates";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lineColumn,
            this.textColumn});
            this.listView.Location = new System.Drawing.Point(12, 25);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(320, 375);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(257, 406);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "OK";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // lineColumn
            // 
            this.lineColumn.Text = "Line";
            // 
            // textColumn
            // 
            this.textColumn.Text = "Text";
            this.textColumn.Width = 171;
            // 
            // DuplicatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.duplicatesLabel);
            this.MaximizeBox = false;
            this.Name = "DuplicatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Found duplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label duplicatesLabel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ColumnHeader lineColumn;
        private System.Windows.Forms.ColumnHeader textColumn;
    }
}