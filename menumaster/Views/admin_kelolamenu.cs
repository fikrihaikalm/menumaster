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
        private HashSet<int> editedRows;

        public admin_kelolamenu()
        {
            InitializeComponent();
            editedRows = new HashSet<int>();
            LoadData();
            PopulateComboBox();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            button5.Click += button5_Click_1;  // Ensure the event handler is assigned
        }

        private DataTable kelolamenu()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";

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
            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT id_menu, nama AS menu, harga, deskripsi, id_kategori FROM menu";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Make the DataGridView editable
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.ReadOnly = false;
                }
                // Set id_menu column to read-only because it is the primary key
                dataGridView1.Columns["id_menu"].ReadOnly = true;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["menu"].Value.ToString();
                textBox2.Text = selectedRow.Cells["harga"].Value.ToString();
                textBox3.Text = selectedRow.Cells["deskripsi"].Value.ToString();
                comboBox1.SelectedValue = selectedRow.Cells["id_kategori"].Value;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editedRows.Add(e.RowIndex);
                Console.WriteLine("Row edited: " + e.RowIndex);  // Debug message
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

            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                //MessageBox.Show("Pilih baris yang ingin diupdate.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idMenu = Convert.ToInt32(selectedRow.Cells["id_menu"].Value);
            string namaMenu = textBox1.Text;
            decimal hargaMenu;
            if (!decimal.TryParse(textBox2.Text, out hargaMenu))
            {
                MessageBox.Show("Harga harus berupa angka.");
                return;
            }
            string deskripsiMenu = textBox3.Text;
            int jenisKategori = (int)comboBox1.SelectedValue;

            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    bool updateSuccess = true;
                    bool needsUpdate = false;

                    // Compare each field to determine if it has changed
                    string updateQuery = "UPDATE menu SET ";
                    if (namaMenu != selectedRow.Cells["menu"].Value.ToString())
                    {
                        updateQuery += "nama = @nama, ";
                        needsUpdate = true;
                    }
                    if (hargaMenu != Convert.ToDecimal(selectedRow.Cells["harga"].Value))
                    {
                        updateQuery += "harga = @harga, ";
                        needsUpdate = true;
                    }
                    if (deskripsiMenu != selectedRow.Cells["deskripsi"].Value.ToString())
                    {
                        updateQuery += "deskripsi = @deskripsi, ";
                        needsUpdate = true;
                    }
                    if (jenisKategori != Convert.ToInt32(selectedRow.Cells["id_kategori"].Value))
                    {
                        updateQuery += "id_kategori = @id_kategori, ";
                        needsUpdate = true;
                    }

                    // If nothing needs to be updated, return
                    if (!needsUpdate)
                    {
                        MessageBox.Show("Tidak ada perubahan untuk diupdate.");
                        return;
                    }

                    // Remove the last comma and space
                    updateQuery = updateQuery.TrimEnd(',', ' ') + " WHERE id_menu = @id_menu";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        if (updateQuery.Contains("@nama"))
                            command.Parameters.AddWithValue("@nama", namaMenu);
                        if (updateQuery.Contains("@harga"))
                            command.Parameters.AddWithValue("@harga", hargaMenu);
                        if (updateQuery.Contains("@deskripsi"))
                            command.Parameters.AddWithValue("@deskripsi", deskripsiMenu);
                        if (updateQuery.Contains("@id_kategori"))
                            command.Parameters.AddWithValue("@id_kategori", jenisKategori);
                        command.Parameters.AddWithValue("@id_menu", idMenu);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Update gagal.");
                            updateSuccess = false;
                        }
                    }

                    if (updateSuccess)
                    {
                        MessageBox.Show("Data berhasil diupdate!");
                        LoadData(); // Refresh data
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


    }
}
