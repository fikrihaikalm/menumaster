using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace menumaster.Views
{
    public partial class waiter_pesanan : Form
    {
        private List<string> pesananList = new List<string>();
        private List<int> menuIDs = new List<int>();
        private string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menumaster";

        public waiter_pesanan()
        {
            InitializeComponent();
            LoadMakanan();
        }

        private void LoadMakanan()
        {
            panelItems.Controls.Clear();
            string query = "SELECT id_menu, nama, harga FROM menu WHERE id_kategori = '1'";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMenu = reader.GetInt32(0);
                            string namaMenu = reader.GetString(1);
                            decimal harga = reader.GetDecimal(2);
                            panelItems.Controls.Add(CreateItemPanel(namaMenu, idMenu, "path_to_image.jpg", harga));
                        }
                    }
                }
            }

            buttonMakanan.BackColor = Color.Blue;
            buttonMinuman.BackColor = default(Color);
            buttonSnack.BackColor = default(Color);
        }

        private void LoadMinuman()
        {
            panelItems.Controls.Clear();
            string query = "SELECT id_menu, nama, harga FROM menu WHERE id_kategori = '2'";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMenu = reader.GetInt32(0);
                            string namaMenu = reader.GetString(1);
                            decimal harga = reader.GetDecimal(2);
                            panelItems.Controls.Add(CreateItemPanel(namaMenu, idMenu, "path_to_image.jpg", harga));
                        }
                    }
                }
            }

            buttonMinuman.BackColor = Color.Blue;
            buttonMakanan.BackColor = default(Color);
            buttonSnack.BackColor = default(Color);
        }

        private void LoadSnack()
        {
            panelItems.Controls.Clear();
            string query = "SELECT id_menu, nama, harga FROM menu WHERE id_kategori = '3'";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idMenu = reader.GetInt32(0);
                            string namaMenu = reader.GetString(1);
                            decimal harga = reader.GetDecimal(2);
                            panelItems.Controls.Add(CreateItemPanel(namaMenu, idMenu, "path_to_image.jpg", harga));
                        }
                    }
                }
            }

            buttonSnack.BackColor = Color.Blue;
            buttonMakanan.BackColor = default(Color);
            buttonMinuman.BackColor = default(Color);
        }

        private decimal totalHarga = 0;

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var itemInfo = (Tuple<string, int, decimal>)button.Tag;
            string itemName = itemInfo.Item1;
            int itemID = itemInfo.Item2;
            decimal itemPrice = itemInfo.Item3;

            pesananList.Add(itemName);
            menuIDs.Add(itemID);
            totalHarga += itemPrice;
            UpdatePesananPanel();
            lblTotalHarga.Text = $"Total Harga: Rp {totalHarga:N2}";
        }

        private void DelItemButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var itemInfo = (Tuple<string, int, decimal>)button.Tag;
            string itemName = itemInfo.Item1;
            int itemID = itemInfo.Item2;
            decimal itemPrice = itemInfo.Item3;

            if (totalHarga >= 0)
            {
                // Hapus item dari pesanan
                pesananList.Remove(itemName);
                menuIDs.Remove(itemID);
                totalHarga -= itemPrice;

                UpdatePesananPanel();
                lblTotalHarga.Text = $"Total Harga: Rp {totalHarga:N2}";
            }
            else 
            { 
                return;
            }
        }

        private FlowLayoutPanel CreateItemPanel(string itemName, int itemID, string imagePath, decimal itemPrice)
        {
            FlowLayoutPanel itemPanel = new FlowLayoutPanel();
            itemPanel.Size = new Size(150, 180);

            Label itemNameLabel = new Label();
            itemNameLabel.Text = itemName;

            Label itemPriceLabel = new Label();
            itemPriceLabel.Text = $"Rp {itemPrice:N2}";

            Button addItemButton = new Button();
            addItemButton.Text = "+";
            addItemButton.Tag = new Tuple<string, int, decimal>(itemName, itemID, itemPrice);
            addItemButton.Click += new EventHandler(AddItemButton_Click);

            Button delItemButton = new Button();
            delItemButton.Text = "-";
            delItemButton.Tag = new Tuple<string, int, decimal>(itemName, itemID, itemPrice);
            delItemButton.Click += new EventHandler(DelItemButton_Click);


            itemPanel.Controls.Add(itemNameLabel);
            itemPanel.Controls.Add(itemPriceLabel);
            itemPanel.Controls.Add(addItemButton);
            itemPanel.Controls.Add(delItemButton);
            return itemPanel;
        }

        private void UpdatePesananPanel()
        {
            panelPesanan.Controls.Clear();
            foreach (string item in pesananList)
            {
                Label itemLabel = new Label();
                itemLabel.Text = item;
                panelPesanan.Controls.Add(itemLabel);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (pesananList.Count == 0)
            {
                MessageBox.Show("Pesanan kosong!");
                return;
            }

            int pelangganID;
            int metodePembayaranID;
            int karyawanID;

            if (!int.TryParse(txtPelangganID.Text, out pelangganID) ||
                !int.TryParse(txtMetodePembayaranID.Text, out metodePembayaranID) ||
                !int.TryParse(txtKaryawanID.Text, out karyawanID))
            {
                MessageBox.Show("ID Pelanggan, ID Metode Pembayaran, dan ID Karyawan harus berupa angka!");
                return;
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert into pesanan table
                        string insertPesananQuery = "INSERT INTO pesanan (tanggal_pemesanan, total_harga, total_tax, ID_pelanggan, ID_metode_pembayaran, ID_karyawan) VALUES (@tanggal_pemesanan, @total_harga, @total_tax, @ID_pelanggan, @ID_metode_pembayaran, @ID_karyawan) RETURNING ID_pesanan";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(insertPesananQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("tanggal_pemesanan", DateTime.Now);
                            cmd.Parameters.AddWithValue("total_harga", 100000); // Calculate this based on order details
                            cmd.Parameters.AddWithValue("total_tax", 10000);   // Calculate this based on order details
                            cmd.Parameters.AddWithValue("ID_pelanggan", pelangganID);
                            cmd.Parameters.AddWithValue("ID_metode_pembayaran", metodePembayaranID);
                            cmd.Parameters.AddWithValue("ID_karyawan", karyawanID);

                            int pesananID = (int)cmd.ExecuteScalar();

                            // Insert into detail_pesanan table
                            string insertDetailPesananQuery = "INSERT INTO detail_pesanan (ID_pesanan, ID_menu, jumlah, diskon, sub_total) VALUES (@ID_pesanan, @ID_menu, @jumlah, @diskon, @sub_total)";
                            foreach (int menuID in menuIDs)
                            {
                                using (NpgsqlCommand detailCmd = new NpgsqlCommand(insertDetailPesananQuery, conn))
                                {
                                    detailCmd.Parameters.AddWithValue("ID_pesanan", pesananID);
                                    detailCmd.Parameters.AddWithValue("ID_menu", menuID);
                                    detailCmd.Parameters.AddWithValue("jumlah", 1); // Assume quantity is 1 for simplicity
                                    detailCmd.Parameters.AddWithValue("diskon", 0.00);
                                    detailCmd.Parameters.AddWithValue("sub_total", 10000); // Calculate this based on order details

                                    detailCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        trans.Commit();
                        MessageBox.Show("Pesanan berhasil disimpan!");
                        pesananList.Clear();
                        menuIDs.Clear();
                        UpdatePesananPanel();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }

        private void ButtonMakanan_Click(object sender, EventArgs e)
        {
            LoadMakanan();
        }

        private void ButtonMinuman_Click(object sender, EventArgs e)
        {
            LoadMinuman();
        }

        private void ButtonSnack_Click(object sender, EventArgs e)
        {
            LoadSnack();
        }
    }
}
