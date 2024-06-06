using menumaster.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menumaster.Views
{
    public partial class Manager_KelolaKaryawan : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=MenuMaster";
        public Manager_KelolaKaryawan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Homepage f2 = new Manager_Homepage();
            f2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_TambahKaryawan f3 = new Manager_TambahKaryawan();
            f3.Show();
            this.Hide();
        }

        private void Manager_KelolaKaryawan_Load(object sender, EventArgs e)
        {
            LoadKaryawanData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadKaryawanData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM karyawan";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
