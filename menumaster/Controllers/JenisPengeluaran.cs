using System;
using menumaster.Helpers;
using menumaster.Models;
using Npgsql;

namespace menumaster.Controllers
{
    public class JenisPengeluaranController
    {
        public bool TambahJenisPengeluaran(JenisPengeluaran jenis)
        {
            string query = "INSERT INTO jenis_pengeluaran (nama_pengeluaran) VALUES (@nama)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", jenis.NamaPengeluaran)
            };

            try
            {
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
