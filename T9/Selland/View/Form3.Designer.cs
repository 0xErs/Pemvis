namespace Selland.Views
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelJudul = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelLuas = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxLuas = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.LabelAlamat = new System.Windows.Forms.Label();
            this.LabelHarga = new System.Windows.Forms.Label();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDell = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 57);
            this.panel1.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(11, 6);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(52, 38);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(86, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "SelLand";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 175);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LabelJudul
            // 
            this.LabelJudul.AutoSize = true;
            this.LabelJudul.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJudul.Location = new System.Drawing.Point(22, 281);
            this.LabelJudul.Name = "LabelJudul";
            this.LabelJudul.Size = new System.Drawing.Size(43, 20);
            this.LabelJudul.TabIndex = 3;
            this.LabelJudul.Text = "Judul";
            this.LabelJudul.Click += new System.EventHandler(this.LabelJudul_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(22, 316);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(49, 20);
            this.LabelStatus.TabIndex = 4;
            this.LabelStatus.Text = "Status";
            this.LabelStatus.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelLuas
            // 
            this.LabelLuas.AutoSize = true;
            this.LabelLuas.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLuas.Location = new System.Drawing.Point(22, 351);
            this.LabelLuas.Name = "LabelLuas";
            this.LabelLuas.Size = new System.Drawing.Size(38, 20);
            this.LabelLuas.TabIndex = 5;
            this.LabelLuas.Text = "Luas";
            this.LabelLuas.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Location = new System.Drawing.Point(94, 281);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(184, 22);
            this.textBoxJudul.TabIndex = 6;
            this.textBoxJudul.TextChanged += new System.EventHandler(this.textBoxJudul_TextChanged);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(94, 316);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(184, 22);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // textBoxLuas
            // 
            this.textBoxLuas.Location = new System.Drawing.Point(94, 351);
            this.textBoxLuas.Name = "textBoxLuas";
            this.textBoxLuas.Size = new System.Drawing.Size(184, 22);
            this.textBoxLuas.TabIndex = 8;
            this.textBoxLuas.TextChanged += new System.EventHandler(this.textBoxLuas_TextChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(459, 281);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(184, 57);
            this.textBoxAlamat.TabIndex = 9;
            this.textBoxAlamat.TextChanged += new System.EventHandler(this.textBoxAlamat_TextChanged);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(459, 351);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(184, 22);
            this.textBoxHarga.TabIndex = 10;
            this.textBoxHarga.TextChanged += new System.EventHandler(this.textBoxHarga_TextChanged);
            // 
            // LabelAlamat
            // 
            this.LabelAlamat.AutoSize = true;
            this.LabelAlamat.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlamat.Location = new System.Drawing.Point(344, 281);
            this.LabelAlamat.Name = "LabelAlamat";
            this.LabelAlamat.Size = new System.Drawing.Size(57, 20);
            this.LabelAlamat.TabIndex = 11;
            this.LabelAlamat.Text = "Alamat";
            // 
            // LabelHarga
            // 
            this.LabelHarga.AutoSize = true;
            this.LabelHarga.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHarga.Location = new System.Drawing.Point(344, 351);
            this.LabelHarga.Name = "LabelHarga";
            this.LabelHarga.Size = new System.Drawing.Size(50, 20);
            this.LabelHarga.TabIndex = 12;
            this.LabelHarga.Text = "Harga";
            // 
            // BtnTambah
            // 
            this.BtnTambah.BackColor = System.Drawing.Color.Violet;
            this.BtnTambah.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTambah.Location = new System.Drawing.Point(26, 397);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(86, 31);
            this.BtnTambah.TabIndex = 13;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = false;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Violet;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(131, 397);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(86, 31);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDell
            // 
            this.BtnDell.BackColor = System.Drawing.Color.Violet;
            this.BtnDell.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDell.Location = new System.Drawing.Point(237, 397);
            this.BtnDell.Name = "BtnDell";
            this.BtnDell.Size = new System.Drawing.Size(86, 31);
            this.BtnDell.TabIndex = 15;
            this.BtnDell.Text = "Hapus";
            this.BtnDell.UseVisualStyleBackColor = false;
            this.BtnDell.Click += new System.EventHandler(this.BtnDell_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnSimpan.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Location = new System.Drawing.Point(693, 397);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(86, 31);
            this.BtnSimpan.TabIndex = 16;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(459, 397);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(86, 31);
            this.BtnClear.TabIndex = 17;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.BtnDell);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.LabelHarga);
            this.Controls.Add(this.LabelAlamat);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxLuas);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.LabelLuas);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelJudul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelJudul;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelLuas;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxLuas;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label LabelAlamat;
        private System.Windows.Forms.Label LabelHarga;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDell;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnClear;
    }
}