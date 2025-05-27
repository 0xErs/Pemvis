using MySql.Data.MySqlClient;
using Selland.Controller;
using Selland.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Selland.Views
{
    public partial class Form3 : Form
    {
        private int currentUserId;
        private TanahController tanahController;
        private int selectedTanahId = -1;

        public Form3(int idUser, TanahController controller)
        {
            InitializeComponent();
            tanahController = controller;
            currentUserId = idUser;
            LoadTanahData();
        }

        private void LoadTanahData()
        {
            try
            {
                dataGridView1.DataSource = tanahController.LoadTanah(currentUserId);
                dataGridView1.Columns["id_tanah"].Visible = false; // Menghilangkan ID tanah dari tampilan
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            textBoxJudul.Clear();
            textBoxStatus.Clear();
            textBoxLuas.Clear();
            textBoxAlamat.Clear();
            textBoxHarga.Clear();
            selectedTanahId = -1;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJudul_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Tanah tanah = new Tanah
            {
                Judul = textBoxJudul.Text,
                Status = textBoxStatus.Text,
                Luas = double.Parse(textBoxLuas.Text),
                Alamat = textBoxAlamat.Text,
                Harga = decimal.Parse(textBoxHarga.Text),
                UserId = currentUserId
            };

            if (tanahController.AddTanah(tanah))
            {
                MessageBox.Show("Data berhasil ditambahkan!");
                LoadTanahData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan data.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedTanahId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_tanah"].Value);
                textBoxJudul.Text = dataGridView1.SelectedRows[0].Cells["judul"].Value.ToString();
                textBoxStatus.Text = dataGridView1.SelectedRows[0].Cells["status"].Value.ToString();
                textBoxLuas.Text = dataGridView1.SelectedRows[0].Cells["luas"].Value.ToString();
                textBoxAlamat.Text = dataGridView1.SelectedRows[0].Cells["alamat"].Value.ToString();
                textBoxHarga.Text = dataGridView1.SelectedRows[0].Cells["harga"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu.");
            }
        }

        private void BtnDell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idTanah = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_tanah"].Value);

                DialogResult confirm = MessageBox.Show(
                    "Yakin ingin menghapus data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    TanahController controller = new TanahController();
                    bool isDeleted = controller.DeleteTanah(idTanah);

                    if (isDeleted)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        LoadTanahData(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedTanahId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diubah dengan tombol Edit.");
                return;
            }

            Tanah tanah = new Tanah
            {
                Id = selectedTanahId,
                Judul = textBoxJudul.Text,
                Status = textBoxStatus.Text,
                Luas = double.Parse(textBoxLuas.Text),
                Alamat = textBoxAlamat.Text,
                Harga = decimal.Parse(textBoxHarga.Text)
            };

            if (tanahController.EditTanah(tanah))
            {
                MessageBox.Show("Data berhasil diperbarui!");
                LoadTanahData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LabelJudul_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form2 dashboard = new Form2(currentUserId);
            dashboard.Show();
            this.Hide();
        }

        private void textBoxLuas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
