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
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }
        private void btnNewKdrama_Click(object sender, EventArgs e)
        {

        }
    }
}