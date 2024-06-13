using System;
using System.Data;
using Npgsql;
using menumaster.Helpers;

namespace menumaster.Controllers
{
    public class AdminMenuController
    {
        public DataTable GetMenuData()
        {
            string query = "SELECT id_menu, nama AS menu, harga, deskripsi, id_kategori FROM menu";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetCategories()
        {
            string query = "SELECT id_kategori, kategori FROM kategori_menu";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public void AddMenu(string nama, decimal harga, string deskripsi, int idKategori)
        {
            string query = "INSERT INTO menu (nama, harga, deskripsi, id_kategori) VALUES (@nama, @harga, @deskripsi, @id_kategori)";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@harga", harga),
                new NpgsqlParameter("@deskripsi", deskripsi),
                new NpgsqlParameter("@id_kategori", idKategori)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void UpdateMenu(int idMenu, string nama, decimal harga, string deskripsi, int idKategori)
        {
            string query = "UPDATE menu SET nama = @nama, harga = @harga, deskripsi = @deskripsi, id_kategori = @id_kategori WHERE id_menu = @id_menu";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id_menu", idMenu),
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@harga", harga),
                new NpgsqlParameter("@deskripsi", deskripsi),
                new NpgsqlParameter("@id_kategori", idKategori)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
