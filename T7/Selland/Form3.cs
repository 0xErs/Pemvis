using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Selland
{
    public partial class Form3 : Form
    {
        private int currentUserId;
        private int selectedTanahId = -1;

        public Form3(int idUser)
        {
            InitializeComponent();
            currentUserId = idUser;
            LoadTanahData();
        }

        private void LoadTanahData()
        {
            try
            {
                DB db = new DB();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tanah WHERE id_user = @id", db.GetConnection());
                cmd.Parameters.AddWithValue("@id", currentUserId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
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
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tanah (judul, status, luas, alamat, harga, id_user) VALUES (@judul, @status, @luas, @alamat, @harga, @id_user)", db.GetConnection());

            cmd.Parameters.AddWithValue("@judul", textBoxJudul.Text);
            cmd.Parameters.AddWithValue("@status", textBoxStatus.Text);
            cmd.Parameters.AddWithValue("@luas", textBoxLuas.Text);
            cmd.Parameters.AddWithValue("@alamat", textBoxAlamat.Text);
            cmd.Parameters.AddWithValue("@harga", textBoxHarga.Text);
            cmd.Parameters.AddWithValue("@id_user", currentUserId);

            db.OpenConnection();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Data berhasil ditambahkan!");
            else
                MessageBox.Show("Gagal menambahkan data.");
            db.CloseConnection();

            LoadTanahData();
            ClearFields();
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
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_tanah"].Value);
                DialogResult result = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB db = new DB();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tanah WHERE id_tanah=@id", db.GetConnection());
                    cmd.Parameters.AddWithValue("@id", id);

                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();

                    LoadTanahData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.");
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

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("UPDATE tanah SET judul=@judul, status=@status, luas=@luas, alamat=@alamat, harga=@harga WHERE id_tanah=@id", db.GetConnection());

            cmd.Parameters.AddWithValue("@judul", textBoxJudul.Text);
            cmd.Parameters.AddWithValue("@status", textBoxStatus.Text);
            cmd.Parameters.AddWithValue("@luas", textBoxLuas.Text);
            cmd.Parameters.AddWithValue("@alamat", textBoxAlamat.Text);
            cmd.Parameters.AddWithValue("@harga", textBoxHarga.Text);
            cmd.Parameters.AddWithValue("@id", selectedTanahId);

            db.OpenConnection();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Data berhasil diperbarui!");
            else
                MessageBox.Show("Gagal memperbarui data.");
            db.CloseConnection();

            LoadTanahData();
            ClearFields();
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
