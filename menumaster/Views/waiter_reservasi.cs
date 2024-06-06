using menumaster.Views;
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

namespace menumaster.Forms.Waiters
{
    public partial class waiter_reservasi : Form
    {
        public waiter_reservasi()
        {
            InitializeComponent();
            this.dateTimePickerTanggal.CalendarForeColor = Color.Aqua;
        }

        private void waiters_pemesanan_Load(object sender, EventArgs e)
        {
            LoadMeja();
            LoadMetodePembayaran();
        }

        private void LoadMeja()
        {
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
            string query = "SELECT ID_meja, nomer_meja FROM meja";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMeja = reader.GetInt32(0);
                            int nomerMeja = reader.GetInt32(1);
                            comboBoxMeja.Items.Add(new ComboBoxItem { Text = nomerMeja.ToString(), Value = idMeja });
                        }
                    }
                }
            }
        }

        private void LoadMetodePembayaran()
        {
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
            string query = "SELECT ID_metode_pembayaran, nama_metode FROM metode_pembayaran";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMetode = reader.GetInt32(0);
                            string namaMetode = reader.GetString(1);
                            comboBoxMetodePembayaran.Items.Add(new ComboBoxItem { Text = namaMetode, Value = idMetode });
                        }
                    }
                }
            }
        }

        private int GetPelangganIdByTelp(string telp)
        {
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
            string query = "SELECT id_pelanggan FROM pelanggan WHERE telp = @telp";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("telp", telp);
                    var result = cmd.ExecuteScalar();
                    return result != null ? (int)result : -1; // Return -1 if not found
                }
            }
        }

        private int AddNewPelanggan(string nama, string telp)
        {
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
            string query = "INSERT INTO pelanggan (nama, telp) VALUES (@nama, @telp) RETURNING id_pelanggan";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("telp", telp);
                    var result = cmd.ExecuteScalar();
                    return (int)result; // Return the new pelanggan ID
                }
            }
        }

        /*       private int GetAvailableMejaId(int jumlahOrang)
               {
                   string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
                   string query = "SELECT ID_meja FROM meja WHERE kapasitas >= @jumlahOrang ORDER BY nomer_meja ASC LIMIT 1";

                   using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                   {
                       conn.Open();
                       using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                       {
                           cmd.Parameters.AddWithValue("jumlahOrang", jumlahOrang);
                           var result = cmd.ExecuteScalar();
                           return result != null ? (int)result : -1; // Return -1 if no available meja
                       }
                   }
               }*/
        private int GetAvailableMejaId(int jumlahOrang)
        {
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
            string query = "SELECT id_meja FROM meja WHERE kapasitas >= @jumlahOrang ORDER BY nomer_meja ASC";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("jumlahOrang", NpgsqlTypes.NpgsqlDbType.Integer, jumlahOrang);
                    var result = cmd.ExecuteScalar();
                    return result != null ? (int)result : -1; // Return -1 if no available meja
                }
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            waiter_homepage homePage = new waiter_homepage();
            homePage.Show();
            this.Close();
        }


        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";
            int pelangganId = GetPelangganIdByTelp(textBoxTelp.Text);

            if (pelangganId == -1)
            {
                // Pelanggan tidak ditemukan, tambahkan pelanggan baru
                pelangganId = AddNewPelanggan(textBoxNama.Text, textBoxTelp.Text);
            }

            // Mendapatkan meja yang sesuai dengan kapasitas
            int jumlahOrang = Convert.ToInt32(numericUpDownJumlahOrang.Value);


            // Mendapatkan meja yang sesuai dengan kapasitas
            int mejaId = GetAvailableMejaId(jumlahOrang);

            if (mejaId == -1)
            {
                MessageBox.Show("Tidak ada meja yang tersedia untuk jumlah orang yang diminta.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TimeSpan durasiReservasi = TimeSpan.FromHours((double)numericUpDownDurasi.Value);
                TimeSpan waktuReservasi = TimeSpan.FromHours((double)numericUpDownWaktu.Value);


                string query = "INSERT INTO reservasi_meja (tanggal_reservasi, waktu_reservasi, durasi_reservasi, jumlah_orang, id_meja, id_pelanggan) VALUES (@tanggal_reservasi, @waktu_reservasi, @durasi_reservasi, @jumlah_orang, @ID_meja, @ID_pelanggan)";

                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("tanggal_reservasi", dateTimePickerTanggal.Value);
                        cmd.Parameters.AddWithValue("waktu_reservasi", waktuReservasi);
                        cmd.Parameters.AddWithValue("durasi_reservasi", durasiReservasi);
                        cmd.Parameters.AddWithValue("jumlah_orang", jumlahOrang);
                        cmd.Parameters.AddWithValue("ID_meja", (comboBoxMeja.SelectedItem as ComboBoxItem).Value);
                        cmd.Parameters.AddWithValue("ID_pelanggan", pelangganId);

                        cmd.ExecuteNonQuery();
                    }
                }

                DialogResult result = MessageBox.Show("Reservasi sudah dibuat", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Hide(); // Menyembunyikan form saat ini
                    waiter_homepage homePage = new waiter_homepage();
                    homePage.Show(); // Menampilkan form HomePage
                }

            }


        }
    }
}
