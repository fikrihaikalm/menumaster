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

namespace menumaster.Views
{
    public partial class admin_kelolamenu : Form
    {
        public admin_kelolamenu()
        {
            InitializeComponent();
            LoadData();
            PopulateComboBox();
        }

        private DataTable kelolamenu()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=menu master";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT id_kategori, kategori FROM kategori_menu";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void PopulateComboBox()
        {
            DataTable categories = kelolamenu();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "kategori";
            comboBox1.ValueMember = "id_kategori";
        }

        private void admin_kelolamenu_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=menu master";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT id_menu, nama AS menu, harga, deskripsi FROM menu";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string namaMenu = textBox1.Text;
            decimal hargaMenu;
            if (!decimal.TryParse(textBox2.Text, out hargaMenu))
            {
                MessageBox.Show("Harga harus berupa angka");
                return;
            }
            string deskripsiMenu = textBox3.Text;
            int jenisKategori = (int)comboBox1.SelectedValue;

            string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=menu master";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string masuk = "INSERT INTO menu (nama, harga, deskripsi, id_kategori) VALUES (@nama, @harga, @deskripsi, @id_kategori)";
                using (NpgsqlCommand command = new NpgsqlCommand(masuk, connection))
                {
                    command.Parameters.AddWithValue("nama", namaMenu);
                    command.Parameters.AddWithValue("harga", hargaMenu);
                    command.Parameters.AddWithValue("deskripsi", deskripsiMenu);
                    command.Parameters.AddWithValue("id_kategori", jenisKategori);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Berhasil!");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        comboBox1.SelectedIndex = -1;

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}