using System;
using menumaster.Helpers;
using Npgsql;

namespace menumaster.Controllers
{
    public class LoginWaiterController
    {
        public int Login(string username, string password)
        {
            string query = "SELECT id_karyawan FROM karyawan WHERE username = @username AND password = @password AND id_role=4";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                throw new Exception("Username atau password salah");
            }
        }
    }
}
