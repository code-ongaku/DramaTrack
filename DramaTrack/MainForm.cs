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
            //connection object
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();

            // command object
            string query = "SELECT * from KDramaList";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a KDrama entry to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enable DataGridView editing mode
            dataGridView1.ReadOnly = false;
            dataGridView1.BeginEdit(true);
        }

        private void btnModifyKdrama_Click(object sender, EventArgs e)
        {
            KDramaForm form = new KDramaForm();
            form.ShowDialog();
        }

        private void btnNewKdrama_Click(object sender, EventArgs e)
        {
            // Create a form for adding a new KDrama entry
            KDramaForm addForm = new KDramaForm();

            // Show the form as a dialog
            DialogResult result = addForm.ShowDialog();

            // If the user confirms the addition
            if (result == DialogResult.OK)
            {
                // Insert the new KDrama entry into the database
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Construct the INSERT query
                    string insertQuery = "INSERT INTO KDramaList (Title, Genre, TotalEpisodes, ProgressStatus) VALUES (@Title, @Genre, @TotalEpisodes, @ProgressStatus)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        // Set parameter values from the form input
                        cmd.Parameters.AddWithValue("@Title", addForm.Title);
                        cmd.Parameters.AddWithValue("@Genre", addForm.Genre);
                        cmd.Parameters.AddWithValue("@TotalEpisodes", addForm.TotalEpisodes);
                        cmd.Parameters.AddWithValue("@ProgressStatus", addForm.ProgressStatus);

                        // Execute the INSERT query
                        cmd.ExecuteNonQuery();
                    }
                }

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
                // Delete the selected KDrama entry from the database
                int dramaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = $"DELETE FROM KDramaList WHERE ID = {dramaId}";
                    using SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
                    cmd.ExecuteNonQuery();
                }

                // Refresh the DataGridView
                PopulateKDramaDataGridView();
            }
        }

    }
}