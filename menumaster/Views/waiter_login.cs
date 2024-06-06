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
            // ID, password valid dan role waiter
            waiter_homepage homepage = new waiter_homepage();
            homepage.Show();
            this.Close();
/*
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";

            // Update query to check role in addition to ID and password
            string query = "SELECT * FROM karyawan WHERE id_karyawan = @id_karyawan AND password = @password and id_role = 4";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_karyawan", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("password", passwordtxt.Text);

                    var result = cmd.ExecuteScalar() as int?;

                    if (result.HasValue && result.Value > 0)
                    {

                    }
                    else
                    {
                        // ID, password salah atau bukan role waiter
                        MessageBox.Show("ID, password salah atau bukan role waiter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
