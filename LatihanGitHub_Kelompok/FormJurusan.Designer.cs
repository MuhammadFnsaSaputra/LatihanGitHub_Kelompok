namespace LatihanGitHub_Kelompok
{
    partial class FormJurusan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblid = new Label();
            lblnisn = new Label();
            lbljurusan = new Label();
            dgvJurusan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnsimpan = new Button();
            btnhapus = new Button();
            btnkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJurusan).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 27);
            textBox3.TabIndex = 2;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(103, 59);
            lblid.Name = "lblid";
            lblid.Size = new Size(29, 20);
            lblid.TabIndex = 3;
            lblid.Text = "Id :";
            // 
            // lblnisn
            // 
            lblnisn.AutoSize = true;
            lblnisn.Location = new Point(82, 117);
            lblnisn.Name = "lblnisn";
            lblnisn.Size = new Size(50, 20);
            lblnisn.TabIndex = 4;
            lblnisn.Text = "NISN :";
            // 
            // lbljurusan
            // 
            lbljurusan.AutoSize = true;
            lbljurusan.Location = new Point(68, 172);
            lbljurusan.Name = "lbljurusan";
            lbljurusan.Size = new Size(64, 20);
            lbljurusan.TabIndex = 5;
            lbljurusan.Text = "Jurusan :";
            // 
            // dgvJurusan
            // 
            dgvJurusan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJurusan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvJurusan.Location = new Point(68, 344);
            dgvJurusan.Name = "dgvJurusan";
            dgvJurusan.RowHeadersWidth = 51;
            dgvJurusan.Size = new Size(427, 188);
            dgvJurusan.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "NISN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Jurusan";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(68, 273);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(94, 29);
            btnsimpan.TabIndex = 7;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnhapus
            // 
            btnhapus.Location = new Point(241, 273);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(94, 29);
            btnhapus.TabIndex = 8;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(401, 273);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(94, 29);
            btnkembali.TabIndex = 9;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // FormJurusan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 564);
            Controls.Add(btnkembali);
            Controls.Add(btnhapus);
            Controls.Add(btnsimpan);
            Controls.Add(dgvJurusan);
            Controls.Add(lbljurusan);
            Controls.Add(lblnisn);
            Controls.Add(lblid);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormJurusan";
            Text = "FormJurusan";
            ((System.ComponentModel.ISupportInitialize)dgvJurusan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblid;
        private Label lblnisn;
        private Label lbljurusan;
        private DataGridView dgvJurusan;
        private Button btnsimpan;
        private Button btnhapus;
        private Button btnkembali;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}