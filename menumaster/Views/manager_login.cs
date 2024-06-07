using menumaster.Forms;
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
    public partial class Login_manajer : Form
    {
        public static int KaryawanID { get; private set; }

        public Login_manajer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("ID dan password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idKaryawan;
            if (!int.TryParse(textBox1.Text, out idKaryawan))
            {
                MessageBox.Show("ID karyawan harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT COUNT(*) FROM karyawan WHERE id_karyawan = @id_karyawan AND password = @password AND id_role = 1";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_karyawan", idKaryawan),
                new NpgsqlParameter("@password", textBox2.Text)
            };

            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        int result = Convert.ToInt32(command.ExecuteScalar());

                        if (result > 0)
                        {
                            // Simpan ID karyawan
                            KaryawanID = idKaryawan;

                            // ID, password valid dan role manager
                            Manager_Homepage homepage = new Manager_Homepage();
                            homepage.Show();
                            this.Close();
                        }
                        else
                        {
                            // ID, password salah atau bukan role manager
                            MessageBox.Show("ID, password salah atau bukan role manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Login_manajer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
