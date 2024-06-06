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
    public partial class admin_pengeluaran : Form
    {
        private DateTime tanggal1;
        private DateTime tanggal2;

        private DateOnly tanggalawal;
        private DateOnly tanggalakhir;

        public admin_pengeluaran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page adminPage = new admin_page();
            adminPage.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle combo box selection change if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void admin_pengeluaran_Load(object sender, EventArgs e)
        {
            // Load data when the form loads
            LoadPengeluaranData();
        }

        private void LoadPengeluaranData()
        {
            tanggal1 = dateTimePicker1.Value;
            tanggalawal = DateOnly.FromDateTime(tanggal1); // Only date, no time

            tanggal2 = dateTimePicker2.Value;
            tanggalakhir = DateOnly.FromDateTime(tanggal2); // Only date, no time

            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "select p.tanggal_pengeluaran as tanggal, p.jumlah_pengeluaran as jumlah, jp.nama_pengeluaran as jenis from pengeluaran_operasional p join jenis_pengeluaran jp on (p.id_jenis_pengeluaran = jp.id_jenis_pengeluaran) WHERE p.tanggal_pengeluaran >= @tanggalawal and p.tanggal_pengeluaran <= @tanggalakhir";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@tanggalawal", tanggalawal);
                        command.Parameters.AddWithValue("@tanggalakhir", tanggalakhir);

                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reload data based on the selected dates
            LoadPengeluaranData();
        }
    }
}