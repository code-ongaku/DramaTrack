using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DramaTrack
{
    public partial class KDramaForm : Form
    {

        private string connectionString = @"data source=C:\Users\RumaisaT\source\own\DramaTrack\Database\Dramabase.db;";

        public KDramaForm()
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the edited KDrama entry's details
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            int dramaId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);
            string columnName = dataGridView1.Columns[colIndex].Name;
            string newValue = dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString();

            // Update the corresponding record in the database
            string updateQuery = $"UPDATE KDramaList SET {columnName} = @NewValue WHERE ID = {dramaId}";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.ExecuteNonQuery();
                }
            }

            // Disable DataGridView editing mode after editing is finished
            dataGridView1.ReadOnly = true;
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
