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
    public partial class Form4 : Form
    {
        private UserController userController = new UserController();
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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            if (userController.Register(username, password))
            {
                MessageBox.Show("Akun berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            else
            {
                MessageBox.Show("Gagal mendaftar, silakan coba lagi.");
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
