using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DramaTrack
{
    public partial class KDramaForm : Form
    {
        public KDramaForm()
        {
            InitializeComponent();
            InitializeKDramas();
        }

        private void InitializeKDramas()
        {
            // Populate ListView with KDrama entries
            listViewKDramas.View = View.Details;
            listViewKDramas.Columns.Add("KDrama Name", 200);
            listViewKDramas.Columns.Add("Total Episodes", 100);
            listViewKDramas.Columns.Add("Episodes Watched", 120);
            listViewKDramas.Columns.Add("Genre", 150);

            // Add sample KDrama entries (replace with your data source)
            ListViewItem kdrama1 = new ListViewItem(new[] { "Goblin", "16", "10", "Romance, Fantasy" });
            ListViewItem kdrama2 = new ListViewItem(new[] { "Crash Landing on You", "16", "16", "Thriller, Romance" });

            listViewKDramas.Items.AddRange(new[] { kdrama1, kdrama2 });

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewKDramas.SelectedItems.Count > 0)
            {
                // Prompt user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this KDrama entry?", "Confirmation", MessageBoxButtons.OKCancel);

                // If user confirms deletion
                if (result == DialogResult.OK)
                {
                    // Remove the selected item from the ListView
                    listViewKDramas.Items.Remove(listViewKDramas.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select a KDrama to delete.");
            }
        }
    }
}
