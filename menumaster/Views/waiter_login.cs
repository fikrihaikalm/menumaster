using menumaster.Helpers;
using menumaster.Views;
using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace menumaster
{
    public partial class Login_kasir : Form
    {
        public Login_kasir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePageForm f1 = new WelcomePageForm();
            f1.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(passwordtxt.Text))
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

            string query = "SELECT COUNT(*) FROM karyawan WHERE id_karyawan = @id_karyawan AND password = @password AND id_role = 4";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_karyawan", idKaryawan),
                new NpgsqlParameter("@password", passwordtxt.Text)
            };

            int result = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));

            if (result > 0)
            {
                // ID, password valid dan role waiter
                waiter_homepage homepage = new waiter_homepage();
                homepage.Show();
                this.Close();
            }
            else
            {
                // ID, password salah atau bukan role waiter
                MessageBox.Show("ID, password salah atau bukan role waiter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
