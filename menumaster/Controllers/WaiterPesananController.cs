using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using menumaster.Helpers;
using menumaster.Models;
using Npgsql;

namespace menumaster.Controllers
{
    public class WaiterPesananController
    {
        public List<MenuItem> GetMenuItems(int kategoriID)
        {
            string query = "SELECT id_menu, nama, harga FROM menu WHERE id_kategori = @kategoriID";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@kategoriID", kategoriID)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            var items = new List<MenuItem>();

            foreach (DataRow row in dt.Rows)
            {
                items.Add(new MenuItem
                {
                    ID = Convert.ToInt32(row["id_menu"]),
                    Nama = row["nama"].ToString(),
                    Harga = Convert.ToDecimal(row["harga"])
                });
            }
            return items;
        }

        public int GetOrCreatePelanggan(string nama, string noTelp)
        {
            string query = "SELECT id_pelanggan FROM pelanggan WHERE telp = @noTelp";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@noTelp", noTelp)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["id_pelanggan"]);
            }
            else
            {
                string insertQuery = "INSERT INTO pelanggan (nama, telp) VALUES (@nama, @Telp) RETURNING id_pelanggan";
                NpgsqlParameter[] insertParameters = {
                    new NpgsqlParameter("@nama", nama),
                    new NpgsqlParameter("@Telp", noTelp)
                };
                return (int)DatabaseHelper.ExecuteScalar(insertQuery, insertParameters);
            }
        }

        public List<MetodePembayaran> GetMetodePembayaran()
        {
            string query = "SELECT id_metode_pembayaran, nama_metode FROM metode_pembayaran";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            var metodePembayaranList = new List<MetodePembayaran>();

            foreach (DataRow row in dt.Rows)
            {
                metodePembayaranList.Add(new MetodePembayaran
                {
                    ID = Convert.ToInt32(row["id_metode_pembayaran"]),
                    Nama = row["nama_metode"].ToString()
                });
            }
            return metodePembayaranList;
        }

        public void SubmitPesanan(Pesanan pesanan)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string insertPesananQuery = "INSERT INTO pesanan (tanggal_pemesanan, total_harga, total_tax, ID_pelanggan, ID_metode_pembayaran, ID_karyawan) VALUES (@tanggal_pemesanan, @total_harga, @total_tax, @ID_pelanggan, @ID_metode_pembayaran, @ID_karyawan) RETURNING ID_pesanan";
                        NpgsqlParameter[] pesananParameters = {
                            new NpgsqlParameter("@tanggal_pemesanan", pesanan.TanggalPemesanan),
                            new NpgsqlParameter("@total_harga", pesanan.TotalHarga),
                            new NpgsqlParameter("@total_tax", pesanan.TotalTax),
                            new NpgsqlParameter("@ID_pelanggan", pesanan.PelangganID),
                            new NpgsqlParameter("@ID_metode_pembayaran", pesanan.MetodePembayaranID),
                            new NpgsqlParameter("@ID_karyawan", pesanan.KaryawanID)
                        };
                        int pesananID = (int)DatabaseHelper.ExecuteScalar(insertPesananQuery, pesananParameters);

                        string insertDetailPesananQuery = "INSERT INTO detail_pesanan (ID_pesanan, ID_menu, jumlah) VALUES (@ID_pesanan, @ID_menu, @jumlah )";
                        foreach (var item in pesanan.Items)
                        {
                            NpgsqlParameter[] detailParameters = {
                                new NpgsqlParameter("@ID_pesanan", pesananID),
                                new NpgsqlParameter("@ID_menu", item.ID),
                                new NpgsqlParameter("@jumlah", item.Jumlah),
                            };
                            DatabaseHelper.ExecuteNonQuery(insertDetailPesananQuery, detailParameters);
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Terjadi kesalahan saat menyimpan pesanan: " + ex.Message);
                    }
                }
            }
        }
    }
}
