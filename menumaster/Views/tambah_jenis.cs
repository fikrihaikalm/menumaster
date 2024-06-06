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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace menumaster.Views
{
    public partial class tambah_jenis : Form
    {
        public tambah_jenis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenis_pengeluaran = textBox1.Text;

            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                // Correct the SQL statement to match the table schema
                string masuk = "INSERT INTO jenis_pengeluaran ( nama_pengeluaran) VALUES (@nama)";
                using (NpgsqlCommand command = new NpgsqlCommand(masuk, connection))
                {
                    // Adjust the parameters to match the SQL statement
                    command.Parameters.AddWithValue("nama", jenis_pengeluaran);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {

                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("gagal");
                    }
                }

            }
        }
    }
}
