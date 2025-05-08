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
    public partial class Form2 : Form
    {
        private int currentUserId;

        // Constructor terima id_user dari Form1
        public Form2(int idUser)
        {
            InitializeComponent();
            currentUserId = idUser;
            LoadDataTanah(); // Tampilkan data saat form dibuka
        }
        // Fungsi untuk mengambil dan menampilkan data tanah milik user
        private void LoadDataTanah()
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
                MessageBox.Show("Gagal memuat data tanah: " + ex.Message);
            }
        }

        // Tombol Sell → buka Form3 untuk tambah/edit/hapus tanah
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formSell = new Form3(currentUserId); // Kirim id_user ke Form3
            formSell.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Tombol Logout → keluar dari aplikasi
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
