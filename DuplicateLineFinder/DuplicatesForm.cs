using System.Collections.Generic;
using System.Windows.Forms;

namespace DuplicateLineFinder
{
    public partial class DuplicatesForm : Form
    {
        public DuplicatesForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(List<int> indexes, string[] lines)
        {
            listView.Items.Clear();

            duplicatesLabel.Text = $"Found {indexes.Count} duplicates";

            for (int i = 0; i < indexes.Count; i++)
            {
                ListViewItem item = new ListViewItem((indexes[i] + 1).ToString());
                item.SubItems.Add(lines[i]);
                listView.Items.Add(item);
            }

            ShowDialog();

            closeButton.Focus();
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
