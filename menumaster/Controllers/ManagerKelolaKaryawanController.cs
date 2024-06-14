using System;
using System.Data;
using Npgsql;
using menumaster.Helpers;

namespace menumaster.Controllers
{
    public class ManagerKelolaKaryawanController
    {
        public DataTable GetKaryawanData(string searchKeyword = "")
        {
            string query = "SELECT * FROM karyawan";

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                query += " WHERE nama LIKE @searchKeyword";
            }

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@searchKeyword", "%" + searchKeyword + "%")
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public void DeleteKaryawan(int idKaryawan)
        {
            string query = "DELETE FROM karyawan WHERE id_karyawan = @id_karyawan";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id_karyawan", idKaryawan)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
