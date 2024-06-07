using menumaster.Forms;
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
    public partial class Manager_TambahKaryawan : Form
    {
        // Buat variabel untuk menyimpan koneksi ke database
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345;Database=MenuMaster");

        public Manager_TambahKaryawan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_KelolaKaryawan f1 = new Manager_KelolaKaryawan();
            f1.Show();
            this.Close();
        }

        private void Manager_TambahKaryawan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
             
                conn.Open();

                // Buat perintah SQL untuk menyimpan data
                string sql = "INSERT INTO karyawan (id_karyawan, nama, telp, aktif) VALUES (@id_karyawan, @nama, @telp, @aktif)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    int idKaryawan;

                    if (!Int32.TryParse(textBox1.Text, out idKaryawan))
                    {
                        MessageBox.Show("ID Karyawan harus berupa angka.");
                        return; 
                    }

                    cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);
                    cmd.Parameters.AddWithValue("@nama", textBox2.Text);

                    int telp;
                    // Parse nilai telp
                    if (!Int32.TryParse(textBox3.Text, out telp))
                    {
                        MessageBox.Show("Nomor telepon harus berupa angka.");
                        return; 
                    }
                    cmd.Parameters.AddWithValue("@telp", telp);

                    cmd.Parameters.AddWithValue("@aktif", true); 
                    cmd.ExecuteNonQuery();
                }

                // Tutup koneksi ke database
                conn.Close();


                Manager_KelolaKaryawan kelolaKaryawan = new Manager_KelolaKaryawan();
                kelolaKaryawan.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
