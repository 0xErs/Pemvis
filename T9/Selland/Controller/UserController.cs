using MySql.Data.MySqlClient;
using Selland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selland.Controller
{
    internal class UserController
    {
        private DB db = new DB();

        public User Login(string username, string password)
        {
            db.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE username=@user AND password=@pass", db.GetConnection());
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            User user = null;

            if (reader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(reader["id_user"]),
                    Username = reader["username"].ToString(),
                    Password = password // menjaga password tetap aman tidak disimpan
                };
            }

            db.CloseConnection();
            return user;
        }

        public bool Register(string username, string password)
        {
            db.OpenConnection();

            try
            {
                // Create a new user record
                MySqlCommand cmdUser = new MySqlCommand("INSERT INTO user (nama, no_hp, kontak, biodata, alamat) VALUES ('-', '-', '-', '-', '-')", db.GetConnection());
                cmdUser.ExecuteNonQuery();
                long idUser = cmdUser.LastInsertedId;

                // Create the login record
                MySqlCommand cmdLogin = new MySqlCommand("INSERT INTO login (username, password, id_user) VALUES (@username, @password, @id_user)", db.GetConnection());
                cmdLogin.Parameters.AddWithValue("@username", username);
                cmdLogin.Parameters.AddWithValue("@password", password);
                cmdLogin.Parameters.AddWithValue("@id_user", idUser);
                cmdLogin.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
