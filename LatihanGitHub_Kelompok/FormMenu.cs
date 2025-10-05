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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiswa fs = new FormSiswa();
            fs.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJurusan fs = new FormJurusan();
            fs.ShowDialog();
        }
    }
}
