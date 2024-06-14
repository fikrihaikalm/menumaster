using System;
using System.Data;
using Npgsql;
using menumaster.Helpers;

namespace menumaster.Controllers
{
    public class ManagerTambahKaryawanController
    {
        public void TambahKaryawan(string nama, string telp, string alamat, string foto, bool aktif, string password, string email, DateTime tglMasuk, decimal gaji, int idRole)
        {
            string sql = "INSERT INTO karyawan (nama, telp, alamat, foto, aktif, password, email, tgl_masuk, gaji, ID_role) " +
                         "VALUES (@nama, @telp, @alamat, @foto, @aktif, @password, @email, @tgl_masuk, @gaji, @ID_role)";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@telp", telp),
                new NpgsqlParameter("@alamat", alamat),
                new NpgsqlParameter("@foto", foto),
                new NpgsqlParameter("@aktif", aktif),
                new NpgsqlParameter("@password", password),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@tgl_masuk", tglMasuk),
                new NpgsqlParameter("@gaji", gaji),
                new NpgsqlParameter("@ID_role", idRole)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable GetRoles()
        {
            string sql = "SELECT ID_role AS RoleID, role AS RoleName FROM role"; // Adjust the query according to your table structure
            return DatabaseHelper.ExecuteQuery(sql);
        }
    }
}
