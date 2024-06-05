using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menumaster
{
    public partial class admin_pendapatan : Form
    {
        private string tanggal1;
        private string tanggal2;

        public admin_pendapatan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            tanggal1 = dateTimePicker1.Value.ToString();

            tanggal2 = dateTimePicker2.Value.ToString();

            string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=menumaster2";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "select total_harga as pendapatan, tanggal_pemesanan as tanggal from pesanan where tanggal_pemesanan >= @tanggalawal and tanggal_pemesanan <= @tanggalakhir";

                NpgsqlCommand command = new NpgsqlCommand(sql, conn);


                command.Parameters.AddWithValue("tanggalawal", tanggal1);

                command.Parameters.AddWithValue("tanggalakhir", tanggal2);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
