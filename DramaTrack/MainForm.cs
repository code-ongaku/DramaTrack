using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace DramaTrack
{
    public partial class MainForm : Form
    {
        private string connectionString = @"data source=C:\Users\RumaisaT\source\own\DramaTrack\Database\Dramabase.db;";

        public MainForm()
        {
            InitializeComponent();
            PopulateKDramaDataGridView();      // Populate DataGridView with KDrama entries from the database
        }

        private void PopulateKDramaDataGridView()
        {            
            DataTable dt = new DataTable();

            //connection object
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();

            // command object
            string query = "SELECT * from KDramaList";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                adapter.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }

        private void btnModifyKdrama_Click(object sender, EventArgs e)
        {
            KDramaForm form = new KDramaForm(connectionString, true);
            DialogResult result = form.ShowDialog();

            // If the user confirms the addition
            if (result == DialogResult.OK)
            {

                // Refresh the DataGridView to show the new entry
                PopulateKDramaDataGridView();
            }
        }

        private void btnNewKdrama_Click(object sender, EventArgs e)
        {
            // Create a form for adding a new KDrama entry
            KDramaForm addForm = new KDramaForm(connectionString, false);

            // Show the form as a dialog
            DialogResult result = addForm.ShowDialog();

            // If the user confirms the addition
            if (result == DialogResult.OK)
            {

                // Refresh the DataGridView to show the new entry
                PopulateKDramaDataGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a KDrama entry to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prompt user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this KDrama entry?", "Confirmation", MessageBoxButtons.OKCancel);

            // If user confirms deletion
            if (result == DialogResult.OK)
            {
                // Get the title of the selected KDrama entry
                string title = dataGridView1.SelectedRows[0].Cells["Title"].Value?.ToString() ?? ""; // Using null-conditional operator and providing a fallback value

                // Delete the selected KDrama entry from the database
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = $"DELETE FROM KDramaList WHERE Title = @title";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView
                PopulateKDramaDataGridView();
            }
        }
    }
}