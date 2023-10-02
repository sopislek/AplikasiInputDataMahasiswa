namespace AplikasiInputDataMahasiswa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNim = new TextBox();
            txtNilai = new TextBox();
            txtKelas = new TextBox();
            txtNama = new TextBox();
            GrupBox1 = new GroupBox();
            lvwMahasiswa = new ListView();
            btnHapus = new Button();
            btnTampilkanData = new Button();
            btnSimpan = new Button();
            btnReset = new Button();
            GrupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Nim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 77);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Kelas";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Nilai";
            // 
            // txtNim
            // 
            txtNim.Location = new Point(89, 4);
            txtNim.Name = "txtNim";
            txtNim.Size = new Size(125, 27);
            txtNim.TabIndex = 4;
            // 
            // txtNilai
            // 
            txtNilai.Location = new Point(89, 103);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(125, 27);
            txtNilai.TabIndex = 5;
            txtNilai.KeyPress += txtNilai_KeyPress;
            // 
            // txtKelas
            // 
            txtKelas.Location = new Point(89, 70);
            txtKelas.Name = "txtKelas";
            txtKelas.Size = new Size(125, 27);
            txtKelas.TabIndex = 6;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(89, 37);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(203, 27);
            txtNama.TabIndex = 7;
            // 
            // GrupBox1
            // 
            GrupBox1.Controls.Add(lvwMahasiswa);
            GrupBox1.Controls.Add(btnHapus);
            GrupBox1.Controls.Add(btnTampilkanData);
            GrupBox1.Location = new Point(298, 4);
            GrupBox1.Name = "GrupBox1";
            GrupBox1.Size = new Size(600, 476);
            GrupBox1.TabIndex = 8;
            GrupBox1.TabStop = false;
            GrupBox1.Text = "[ Daftar Mahasiswa ]";
            // 
            // lvwMahasiswa
            // 
            lvwMahasiswa.Location = new Point(6, 60);
            lvwMahasiswa.Name = "lvwMahasiswa";
            lvwMahasiswa.Size = new Size(577, 410);
            lvwMahasiswa.TabIndex = 4;
            lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            lvwMahasiswa.SelectedIndexChanged += lvwMahasiswa_SelectedIndexChanged;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(166, 26);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(98, 28);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTampilkanData
            // 
            btnTampilkanData.Location = new Point(16, 26);
            btnTampilkanData.Name = "btnTampilkanData";
            btnTampilkanData.Size = new Size(144, 28);
            btnTampilkanData.TabIndex = 2;
            btnTampilkanData.Text = "Tampilkan Data";
            btnTampilkanData.UseVisualStyleBackColor = true;
            btnTampilkanData.Click += btnTampilkanData_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(12, 164);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(98, 28);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(116, 164);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 28);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 488);
            Controls.Add(GrupBox1);
            Controls.Add(txtNama);
            Controls.Add(btnReset);
            Controls.Add(txtKelas);
            Controls.Add(btnSimpan);
            Controls.Add(txtNilai);
            Controls.Add(txtNim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Input Data Mahasiswa ";
            GrupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNim;
        private TextBox txtNilai;
        private TextBox txtKelas;
        private TextBox txtNama;
        private GroupBox GrupBox1;
        private ListView lvwMahasiswa;
        private Button btnHapus;
        private Button btnTampilkanData;
        private Button btnSimpan;
        private Button btnReset;
    }
}