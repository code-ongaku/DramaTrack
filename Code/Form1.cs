using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DramaTrack
{
    public partial class Form1 : Form
    {
        private List<KDrama> _storedKDramas;

        public Form1()
        {
            InitializeComponent();
            InitializeStoredKDramas();
            InitializeComboBox();
        }

        private void InitializeStoredKDramas()
        {
            _storedKDramas = new List<KDrama>
            {
                new KDrama { Name = "Goblin", NumberOfEpisodes = 16, CompletedEpisodes = 16, Thoughts = "Great storyline" },
                new KDrama { Name = "Descendants of the Sun", NumberOfEpisodes = 16, CompletedEpisodes = 16, Thoughts = "Romantic and action-packed" },
                new KDrama { Name = "Crash Landing on You", NumberOfEpisodes = 16, CompletedEpisodes = 16, Thoughts = "Heartwarming and emotional" }
            };
        }

        private void InitializeComboBox()
        {
            storedNamesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var kdrama in _storedKDramas)
            {
                storedNamesComboBox.Items.Add(kdrama.Name);
            }

            storedNamesComboBox.SelectedIndexChanged += (sender, e) =>
            {
                var selectedKDrama = _storedKDramas[storedNamesComboBox.SelectedIndex];
                MessageBox.Show($"Number of Episodes: {selectedKDrama.NumberOfEpisodes}\n" +
                                $"Completed Episodes: {selectedKDrama.CompletedEpisodes}\n" +
                                $"Thoughts: {selectedKDrama.Thoughts}");
            };

            this.Controls.Add(storedNamesComboBox);
        }
    }
}
