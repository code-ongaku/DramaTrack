using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DramaTrack
{
    public partial class KDramaForm : Form
    {
        public string Title { get { return txtTitle.Text; } }
        public string Genre { get { return txtGenre.Text; } }
        public int TotalEpisodes { get { return int.Parse(txtTotalEps.Text); } }
        public int CompletedEpisodes { get { return int.Parse(txtCompleted.Text); } }
        public string ProgressStatus { get { return txtProgress.Text; } }

        private SQLiteConnection connection;
        private bool isEditMode = false;
        private string chosenTitle;

        public KDramaForm(string conn, bool editMode)
        {
            InitializeComponent();
            connection = new SQLiteConnection(conn);
            isEditMode = editMode;
            cmbTitle.Visible = editMode;
            // Populate ComboBox with titles
            if (isEditMode)
            {
                PopulateTitleComboBox();
            }
        }

        private void PopulateTitleComboBox()
        {
            string query = "SELECT Title FROM KDramaList";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbTitle.Items.Add(reader["Title"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving KDrama titles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Event handler for when a title is selected from the ComboBox
        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenTitle = "";
            chosenTitle = cmbTitle.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(chosenTitle))
            {
                // Populate form fields with data for the selected title
                PopulateFormData(chosenTitle);
            }
        }

        private void PopulateFormData(string titleChosen)
        {

            string query = $"SELECT Genre, TotalEpisodes, CompletedEpisodes, ProgressStatus FROM KDramaList WHERE Title = '{titleChosen}'";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                txtTitleT.Text = titleChosen;
                try
                {
                    connection.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtGenre.Text = reader["Genre"].ToString();
                            txtTotalEps.Text = reader["TotalEpisodes"].ToString();
                            txtCompleted.Text = reader["CompletedEpisodes"].ToString();
                            txtProgress.Text = reader["ProgressStatus"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving KDrama data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int totalEpisodes;
            if (!int.TryParse(txtTotalEps.Text, out totalEpisodes))
            {
                MessageBox.Show("Please enter a valid number for Total Episodes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditMode)
            {
                UpdateKDramaInDatabase();
            }
            else
            {
                SaveKDramaToDatabase();
            }

            DialogResult = DialogResult.OK;
        }

        private void SaveKDramaToDatabase()
        {
            string query = "INSERT INTO KDramaList (Title, Genre, TotalEpisodes, CompletedEpisodes, ProgressStatus) VALUES (@title, @genre, @totalEpisodes, @completedEpisodes, @progressStatus)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@genre", Genre);
                cmd.Parameters.AddWithValue("@totalEpisodes", TotalEpisodes);
                cmd.Parameters.AddWithValue("@completedEpisodes", CompletedEpisodes);
                cmd.Parameters.AddWithValue("@progressStatus", ProgressStatus);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving KDrama: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void UpdateKDramaInDatabase()
        {
            string query = "UPDATE KDramaList SET Title = @title, Genre = @genre, TotalEpisodes = @totalEpisodes, CompletedEpisodes = @completedEpisodes, ProgressStatus = @progressStatus WHERE Title = @title";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@genre", Genre);
                cmd.Parameters.AddWithValue("@totalEpisodes", TotalEpisodes);
                cmd.Parameters.AddWithValue("@completedEpisodes", CompletedEpisodes);
                cmd.Parameters.AddWithValue("@progressStatus", ProgressStatus);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating KDrama: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
