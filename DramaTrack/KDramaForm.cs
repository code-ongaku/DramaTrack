/*
 * KDramaForm.cs
 * This form is used for addition and modification of KDrama entries
 * 
 * 
 */

using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DramaTrack
{
    public partial class KDramaForm : Form
    {
        private SQLiteConnection connection;
        private bool isEditMode = false;
        private string chosenTitle = "";

        public KDramaForm(string conn, bool editMode)
        {
            InitializeComponent();
            connection = new SQLiteConnection(conn);
            isEditMode = editMode;
            cmbTitle.Visible = editMode;
            label1.Visible = !editMode;
            label2.Visible = editMode;
            label3.Visible = editMode;
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
                        // ensure that reader["Title"] is not null
                        var title = reader["Title"]?.ToString();
                        if (title != null)
                        {
                            cmbTitle.Items.Add(title);
                        }
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
                txtTitle.Text = titleChosen;
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
            if (isEditMode)
            {
                if(cmbTitle.SelectedItem != null)
                {
                    string query = "UPDATE KDramaList SET Title = @title, Genre = @genre, TotalEpisodes = @totalEpisodes, CompletedEpisodes = @completedEpisodes, ProgressStatus = @progressStatus WHERE Title = @title";
                    SaveKDramaToDatabase(query);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please select a title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtGenre.Text) && !string.IsNullOrWhiteSpace(txtTotalEps.Text) && !string.IsNullOrWhiteSpace(txtProgress.Text))
                {
                    string query = "INSERT INTO KDramaList (Title, Genre, TotalEpisodes, CompletedEpisodes, ProgressStatus) VALUES (@title, @genre, @totalEpisodes, @completedEpisodes, @progressStatus)";
                    SaveKDramaToDatabase(query);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please ensure the title, genre, total episodes and progress boxes are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveKDramaToDatabase(string query)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@totalEpisodes", txtTotalEps.Text);
                cmd.Parameters.AddWithValue("@completedEpisodes", txtCompleted.Text);
                cmd.Parameters.AddWithValue("@progressStatus", txtProgress.Text);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
