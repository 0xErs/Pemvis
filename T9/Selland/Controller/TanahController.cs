using MySql.Data.MySqlClient;
using Selland.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selland.Controller
{
    public class TanahController
    {
        private DB db = new DB();

        public DataTable LoadTanah(int userId)
        {
            DataTable table = new DataTable();
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT id_tanah, judul, status, luas, alamat, harga FROM tanah WHERE id_user = @id", db.GetConnection());
            cmd.Parameters.AddWithValue("@id", userId);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            db.CloseConnection();
            return table;
        }

        public bool AddTanah(Tanah tanah)
        {
            db.OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tanah (judul, status, luas, alamat, harga, id_user) VALUES (@judul, @status, @luas, @alamat, @harga, @id_user)", db.GetConnection());

                cmd.Parameters.AddWithValue("@judul", tanah.Judul);
                cmd.Parameters.AddWithValue("@status", tanah.Status);
                cmd.Parameters.AddWithValue("@luas", tanah.Luas);
                cmd.Parameters.AddWithValue("@alamat", tanah.Alamat);
                cmd.Parameters.AddWithValue("@harga", tanah.Harga);
                cmd.Parameters.AddWithValue("@id_user", tanah.UserId);

                return cmd.ExecuteNonQuery() == 1;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool EditTanah(Tanah tanah)
        {
            db.OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE tanah SET judul=@judul, status=@status, luas=@luas, alamat=@alamat, harga=@harga WHERE id_tanah=@id", db.GetConnection());

                cmd.Parameters.AddWithValue("@judul", tanah.Judul);
                cmd.Parameters.AddWithValue("@status", tanah.Status);
                cmd.Parameters.AddWithValue("@luas", tanah.Luas);
                cmd.Parameters.AddWithValue("@alamat", tanah.Alamat);
                cmd.Parameters.AddWithValue("@harga", tanah.Harga);
                cmd.Parameters.AddWithValue("@id", tanah.Id);

                return cmd.ExecuteNonQuery() == 1;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool DeleteTanah(int idTanah)
        {
            db.OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM tanah WHERE id_tanah=@id", db.GetConnection());
                cmd.Parameters.AddWithValue("@id", idTanah);
                return cmd.ExecuteNonQuery() == 1;
            }
            catch
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
