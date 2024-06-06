using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using menumaster.Views;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace menumaster
{
    public partial class tambah_pengeluaran : Form
    {


        public tambah_pengeluaran()
        {
            InitializeComponent();
        }

        private DataTable GetJenisPengeluaran()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=menu master";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT id_jenis_pengeluaran, nama_pengeluaran FROM jenis_pengeluaran";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void PopulateComboBox()
        {
            DataTable jenisPengeluaranData = GetJenisPengeluaran();
            comboBox1.DataSource = jenisPengeluaranData;
            comboBox1.DisplayMember = "nama_pengeluaran"; 
            comboBox1.ValueMember = "id_jenis_pengeluaran";   
        }

        private void tambah_pengeluaran_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            comboBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBox2.Text = string.Empty;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tambah_jenis jenis = new tambah_jenis();
            jenis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jenisPengeluaran = (int)comboBox1.SelectedValue;
            DateTime tanggal = dateTimePicker1.Value;
            decimal total = decimal.Parse(textBox2.Text);

            string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=menu master";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {

                string masuk = "INSERT INTO pengeluaran_operasional (id_jenis_pengeluaran, tanggal_pengeluaran, jumlah_pengeluaran, id_karyawan) VALUES (@jenis, @tanggal, @total, @karyawan)";
                using (NpgsqlCommand command = new NpgsqlCommand(masuk, connection))
                {
                    command.Parameters.AddWithValue("jenis", jenisPengeluaran);
                    command.Parameters.AddWithValue("tanggal", tanggal);  
                    command.Parameters.AddWithValue("total", total); 
                    command.Parameters.AddWithValue("karyawan", 1);  

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("berhasil !");
                        comboBox1.SelectedIndex = -1;
                        dateTimePicker1.Value = DateTime.Now;
                        textBox2.Clear();
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
