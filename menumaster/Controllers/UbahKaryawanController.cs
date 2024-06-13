using System;
using Npgsql;
using menumaster.Helpers;
using System.Data;

namespace menumaster.Controllers
{
    public class UbahKaryawanController
    {
        public void UbahKaryawan(int idKaryawan, string nama, int telp, bool aktif)
        {
            string sql = "UPDATE karyawan SET nama = @nama, telp = @telp, aktif = @aktif WHERE id_karyawan = @id_karyawan";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id_karyawan", idKaryawan),
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@telp", telp),
                new NpgsqlParameter("@aktif", aktif)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataRow GetKaryawanById(int idKaryawan)
        {
            string sql = "SELECT * FROM karyawan WHERE id_karyawan = @id_karyawan";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id_karyawan", idKaryawan)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
    }
}
