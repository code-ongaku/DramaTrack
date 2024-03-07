using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DramaTrack
{
    public partial class KDramaForm : Form
    {
        public string Title { get { return txtTitle.Text; } }
        public string Genre { get { return txtGenre.Text; } }
        public int TotalEpisodes { get { return int.Parse(txtTotalEps.Text); } }
        public string ProgressStatus { get { return txtProgress.Text; } }

        public KDramaForm()
        {
            InitializeComponent();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate form input here if needed
            // For example, ensure that required fields are filled out
            int totalEpisodes;
            if (!int.TryParse(txtTotalEps.Text, out totalEpisodes))
            {
                MessageBox.Show("Please enter a valid number for Total Episodes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Close the form and return DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
