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
using Selland.Controller;

namespace Selland.Views
{
    public partial class Form2 : Form
    {
        private int currentUserId;
        private TanahController tanahController = new TanahController();    

        // CONSTRUCTOR TERIMA ID_USER DARI FORM1
        public Form2(int idUser)
        {
            InitializeComponent();
            currentUserId = idUser;
            LoadTanahData(); // MENAMPILKAN DATA SAAT FORM DIBUKA
        }
        // FUNGSI UNTUK MENGAMBIL DAN MENAMPILKAN DATA TANAH MILIK USER
        private void LoadTanahData()
        {
            try
            {
                dataGridView1.DataSource = tanahController.LoadTanah(currentUserId);
                dataGridView1.Columns["id_tanah"].Visible = false; // Menghilangkan ID Tanah dari tampilan
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // TOMBOL SELL → MEMBUKA FORM3 UNTUK TAMBAH/EDIT/HAPUS TANAH
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formSell = new Form3(currentUserId, tanahController);
            formSell.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // TOMBOL LOGOUT → KELUAR DARI APLIKASI
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
