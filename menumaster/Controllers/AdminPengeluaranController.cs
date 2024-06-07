using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using menumaster.Helpers;
using menumaster.Models;

namespace menumaster.Controllers
{
    public class AdminPengeluaranController
    {
        private readonly DatabaseHelper _dbHelper;

        public AdminPengeluaranController()
        {
            _dbHelper = new DatabaseHelper(); // Inisialisasi DatabaseHelper
        }

        public List<Pengeluaran> GetPengeluaranData(DateOnly tanggalawal, DateOnly tanggalakhir)
        {
            List<Pengeluaran> pengeluaranList = new List<Pengeluaran>();

            string sql = "SELECT p.tanggal_pengeluaran AS tanggal, p.jumlah_pengeluaran AS jumlah, jp.nama_pengeluaran AS jenis " +
                         "FROM pengeluaran_operasional p " +
                         "JOIN jenis_pengeluaran jp ON (p.id_jenis_pengeluaran = jp.id_jenis_pengeluaran) " +
                         "WHERE p.tanggal_pengeluaran >= @tanggalawal AND p.tanggal_pengeluaran <= @tanggalakhir";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@tanggalawal", tanggalawal),
                new NpgsqlParameter("@tanggalakhir", tanggalakhir)
            };

            try
            {
                DataTable dt = _dbHelper.ExecuteQuery(sql, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    Pengeluaran pengeluaran = new Pengeluaran
                    {
                        TanggalPengeluaran = Convert.ToDateTime(row["tanggal"]),
                        JumlahPengeluaran = Convert.ToDecimal(row["jumlah"]),
                        JenisPengeluaran = row["jenis"].ToString()
                    };
                    pengeluaranList.Add(pengeluaran);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return pengeluaranList;
        }
    }
}
