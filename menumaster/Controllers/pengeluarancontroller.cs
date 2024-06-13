using System;
using System.Data;
using menumaster.Helpers;
using menumaster.Models;
using Npgsql;

namespace menumaster.Controllers
{
    public class Pengeluaran1Controller
    {
        public DataTable GetJenisPengeluaran()
        {
            string query = "SELECT id_jenis_pengeluaran, nama_pengeluaran FROM jenis_pengeluaran";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool TambahPengeluaran(Pengeluaran1 pengeluaran)
        {
            string query = "INSERT INTO pengeluaran_operasional (id_jenis_pengeluaran, tanggal_pengeluaran, jumlah_pengeluaran, id_karyawan) " +
                           "VALUES (@jenis, @tanggal, @jumlah, @karyawan)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@jenis", pengeluaran.IdJenisPengeluaran),
                new NpgsqlParameter("@tanggal", pengeluaran.TanggalPengeluaran),
                new NpgsqlParameter("@jumlah", pengeluaran.JumlahPengeluaran),
                new NpgsqlParameter("@karyawan", pengeluaran.IdKaryawan)
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
