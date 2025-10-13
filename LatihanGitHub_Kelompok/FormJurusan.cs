using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGitHub_Kelompok
{
    public partial class FormJurusan : Form
    {
        public FormJurusan()
        {
            InitializeComponent();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda Yakin Ingin Kembali Ke Halaman Menu?",
                "Konfirmasi Kembali",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                this.Hide();

                FormMenu formMenu = Application.OpenForms["FormMenu"] as FormMenu;

                if (formMenu == null)
                {
                    formMenu = new FormMenu();
                    formMenu.Show();
                }
                else
                {
                    MessageBox.Show("Kembali Dilakukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
