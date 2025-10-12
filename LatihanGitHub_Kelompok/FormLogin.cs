using System.Data;


namespace LatihanGitHub_Kelompok
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void refreshData()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;database = dbGithub; uid=root; pwd= ;");
            try
            {
                conn.Open();
                string query = "SELECT * From buku";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMenu.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=DBPerpustakaan;uid=root;pwd=;");
            try
            {
                conn.Open();
                string query = "INSERT INTO users (id, username, password) VALUES (@id, @username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil disimpan");
                txtId.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

