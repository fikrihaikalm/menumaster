using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using menumaster.Helpers;
using menumaster.Models;

namespace menumaster.Controllers
{
    public class AdminPendapatanController
    {
        public List<Pendapatan> GetPendapatanData(DateOnly tanggalawal, DateOnly tanggalakhir)
        {
            List<Pendapatan> pendapatanList = new List<Pendapatan>();

            string sql = "SELECT total_harga AS pendapatan, tanggal_pemesanan AS tanggal " +
                         "FROM pesanan " +
                         "WHERE tanggal_pemesanan >= @tanggalawal AND tanggal_pemesanan <= @tanggalakhir";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@tanggalawal", tanggalawal),
                new NpgsqlParameter("@tanggalakhir", tanggalakhir)
            };

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(sql, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    Pendapatan pendapatan = new Pendapatan
                    {
                        TotalHarga = Convert.ToDecimal(row["pendapatan"]),
                        TanggalPemesanan = Convert.ToDateTime(row["tanggal"])
                    };
                    pendapatanList.Add(pendapatan);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return pendapatanList;
        }
    }
}
