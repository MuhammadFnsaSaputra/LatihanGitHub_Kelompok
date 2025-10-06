namespace LatihanGitHub_Kelompok
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMenu fs = new FormMenu();
            MessageBox.Show("Tombol Login ditekan!", "Info");
        }
    }
}
