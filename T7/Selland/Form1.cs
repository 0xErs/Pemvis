using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Selland
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE username=@user AND password=@pass", db.GetConnection());
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int idUser = Convert.ToInt32(reader["id_user"]);
                db.CloseConnection();

                // Buka Form2 (Dashboard)
                Form2 dashboard = new Form2(idUser);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                db.CloseConnection();
                MessageBox.Show("Username atau password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDaftar_Click(object sender, EventArgs e)
        {
            Form4 daftar = new Form4();
            daftar.Show();
            this.Hide();
        }
    }
}
