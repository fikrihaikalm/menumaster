using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace menumaster
{
    public partial class Login_admin : Form
    {
        public static int KaryawanID { get; private set; }

        public Login_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string passwordtxt = textBox2.Text; // Assuming textBox2 is for password
            string query = "SELECT id_karyawan FROM karyawan WHERE id_karyawan = @id_karyawan AND password = @password AND id_role = 2";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_karyawan", int.Parse(textBox1.Text)),
                new NpgsqlParameter("@password", passwordtxt)
            };

            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            KaryawanID = Convert.ToInt32(result); // Simpan ID karyawan
                            MessageBox.Show("Login berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            admin_page homepage = new admin_page();
                            homepage.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ID, password salah atau bukan role admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePageForm f1 = new WelcomePageForm();
            f1.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}