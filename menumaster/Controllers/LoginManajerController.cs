using System;
using Npgsql;
using menumaster.Helpers;

namespace menumaster.Controllers
{
    public class LoginManajerController
    {
        public int? AuthenticateUser(int idKaryawan, string password)
        {
            string query = "SELECT id_karyawan FROM karyawan WHERE id_karyawan = @id_karyawan AND password = @password AND id_role = 1";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_karyawan", idKaryawan),
                new NpgsqlParameter("@password", password)
            };

            var result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result != null ? (int?)Convert.ToInt32(result) : null;
        }
    }
}
