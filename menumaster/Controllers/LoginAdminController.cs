using System;
using menumaster.Helpers;
using Npgsql;

namespace menumaster.Controllers
{
    public class LoginAdminController
    {
        public int? AuthenticateUser(int id_karyawan, string password)
        {
            string query = "SELECT id_karyawan FROM karyawan WHERE id_karyawan = @id_karyawan AND password = @password AND id_role = 2";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_karyawan", id_karyawan),
                new NpgsqlParameter("@password", password)
            };

            var result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result != null ? (int?)Convert.ToInt32(result) : null;
        }
    }
}
