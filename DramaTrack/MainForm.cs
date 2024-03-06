namespace DramaTrack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStoredKdrama_Click(object sender, EventArgs e)
        {
            Hide();
            KDramaForm form = new KDramaForm();
            form.ShowDialog();
            Close();
        }
        private void btnNewKdrama_Click(object sender, EventArgs e)
        {

        }
    }
}