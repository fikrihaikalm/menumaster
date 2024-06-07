﻿using menumaster.Forms;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["id_karyawan"].Value);

                // Konfirmasi pengguna sebelum menghapus data
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM karyawan WHERE id_karyawan = @id_karyawan";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id_karyawan", selectedId);
                                cmd.ExecuteNonQuery();
                            }

                            // Refresh DataGridView after deletion
                            LoadKaryawanData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Harap pilih baris untuk dihapus.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadKaryawanData(textBox1.Text);
        }

        private void LoadKaryawanData(string searchKeyword = "")
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM karyawan";

                    // If searchKeyword is not empty, add WHERE clause to the query
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += " WHERE nama LIKE @searchKeyword";
                    }

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                    // If searchKeyword is not empty, add parameter to search for similar names
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");
                    }

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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadKaryawanData(textBox1.Text);
        }

    }
}
