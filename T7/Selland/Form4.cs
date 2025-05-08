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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDaftar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            DB db = new DB();

            try
            {
                db.OpenConnection();

                // Buat user dummy di tabel user agar login bisa berelasi
                MySqlCommand cmdUser = new MySqlCommand("INSERT INTO user (nama, no_hp, kontak, biodata, alamat) VALUES ('-', '-', '-', '-', '-')", db.GetConnection());
                cmdUser.ExecuteNonQuery();

                long idUser = cmdUser.LastInsertedId;

                // Simpan ke tabel login
                MySqlCommand cmdLogin = new MySqlCommand("INSERT INTO login (username, password, id_user) VALUES (@username, @password, @id_user)", db.GetConnection());
                cmdLogin.Parameters.AddWithValue("@username", username);
                cmdLogin.Parameters.AddWithValue("@password", password);
                cmdLogin.Parameters.AddWithValue("@id_user", idUser);
                cmdLogin.ExecuteNonQuery();

                MessageBox.Show("Akun berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void BtnMasuk_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

    }
}
