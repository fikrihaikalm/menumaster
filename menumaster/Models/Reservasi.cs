using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using menumaster.Helpers;

namespace menumaster.Models
{
    public class WaiterReservasiModel
    {
        public DataTable GetMeja()
        {
            string query = "SELECT ID_meja, nomer_meja FROM meja";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetMetodePembayaran()
        {
            string query = "SELECT ID_metode_pembayaran, nama_metode FROM metode_pembayaran";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public int GetPelangganIdByTelp(string telp)
        {
            string query = "SELECT id_pelanggan FROM pelanggan WHERE telp = @telp";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@telp", telp) };
            var result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result != null ? (int)result : -1;
        }

        public int AddNewPelanggan(string nama, string telp)
        {
            string query = "INSERT INTO pelanggan (nama, telp) VALUES (@nama, @telp) RETURNING id_pelanggan";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@telp", telp)
            };
            var result = DatabaseHelper.ExecuteScalar(query, parameters);
            return (int)result;
        }

        public int GetAvailableMejaId(int jumlahOrang)
        {
            string query = "SELECT id_meja FROM meja WHERE kapasitas >= @jumlahOrang ORDER BY nomer_meja ASC";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@jumlahOrang", jumlahOrang)
            };
            var result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result != null ? (int)result : -1;
        }

        public void AddReservasiMeja(DateTime tanggalReservasi, TimeSpan waktuReservasi, TimeSpan durasiReservasi, int jumlahOrang, int mejaId, int pelangganId)
        {
            string query = "INSERT INTO reservasi_meja (tanggal_reservasi, waktu_reservasi, durasi_reservasi, jumlah_orang, id_meja, id_pelanggan) VALUES (@tanggal_reservasi, @waktu_reservasi, @durasi_reservasi, @jumlah_orang, @ID_meja, @ID_pelanggan)";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@tanggal_reservasi", tanggalReservasi),
                new NpgsqlParameter("@waktu_reservasi", waktuReservasi),
                new NpgsqlParameter("@durasi_reservasi", durasiReservasi),
                new NpgsqlParameter("@jumlah_orang", jumlahOrang),
                new NpgsqlParameter("@ID_meja", mejaId),
                new NpgsqlParameter("@ID_pelanggan", pelangganId)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}

