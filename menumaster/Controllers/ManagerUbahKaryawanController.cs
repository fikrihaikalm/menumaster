using System;
using System.Data;
using Npgsql;
using menumaster.Helpers;

namespace menumaster.Controllers
{
    public class ManagerUbahKaryawanController
    {
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

        public void UbahKaryawan(int idKaryawan, string telp, string alamat, string foto, bool aktif, string password, string email, decimal gaji, int idRole)
        {
            string sql = "UPDATE karyawan SET telp = @telp, alamat = @alamat, foto = @foto, aktif = @aktif, password = @password, email = @email, gaji = @gaji, ID_role = @ID_role WHERE id_karyawan = @id_karyawan";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id_karyawan", idKaryawan),
                new NpgsqlParameter("@telp", telp),
                new NpgsqlParameter("@alamat", alamat),
                new NpgsqlParameter("@foto", foto),
                new NpgsqlParameter("@aktif", aktif),
                new NpgsqlParameter("@password", password),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@gaji", gaji),
                new NpgsqlParameter("@ID_role", idRole)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable GetRoles()
        {
            string sql = "SELECT ID_role AS RoleID, role AS RoleName FROM role";
            return DatabaseHelper.ExecuteQuery(sql);
        }
    }
}
