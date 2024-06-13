using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using menumaster.Controllers;
using menumaster.Models;

namespace menumaster.Views
{
    public partial class waiter_pesanan : Form
    {
        private List<MenuItem> pesananList = new List<MenuItem>();
        private WaiterPesananController controller = new WaiterPesananController();
        private decimal totalHarga = 0;

        public waiter_pesanan()
        {
            InitializeComponent();
            LoadMakanan();
            LoadMetodePembayaran();
        }

        private void LoadMakanan()
        {
            LoadItems(1);
            buttonMakanan.BackColor = Color.Blue;
            buttonMinuman.BackColor = default(Color);
            buttonSnack.BackColor = default(Color);
        }

        private void LoadMinuman()
        {
            LoadItems(2);
            buttonMinuman.BackColor = Color.Blue;
            buttonMakanan.BackColor = default(Color);
            buttonSnack.BackColor = default(Color);
        }

        private void LoadSnack()
        {
            LoadItems(3);
            buttonSnack.BackColor = Color.Blue;
            buttonMakanan.BackColor = default(Color);
            buttonMinuman.BackColor = default(Color);
        }

        private void LoadItems(int kategoriID)
        {
            panelItems.Controls.Clear();
            var items = controller.GetMenuItems(kategoriID);
            foreach (var item in items)
            {
                panelItems.Controls.Add(CreateItemPanel(item));
            }
        }

        private FlowLayoutPanel CreateItemPanel(MenuItem item)
        {
            FlowLayoutPanel itemPanel = new FlowLayoutPanel();
            itemPanel.Size = new Size(150, 180);

            Label itemNameLabel = new Label();
            itemNameLabel.Text = item.Nama;
            itemNameLabel.Size = new Size(140, 80);

            Label itemPriceLabel = new Label();
            itemPriceLabel.Text = $"Rp {item.Harga:N2}";
            itemPriceLabel.Size = new Size(200, 60);

            Button addItemButton = new Button();
            addItemButton.Text = "+";
            addItemButton.Size = new Size(40, 40);
            addItemButton.Tag = item;
            addItemButton.Click += AddItemButton_Click;

            Button delItemButton = new Button();
            delItemButton.Text = "-";
            delItemButton.Size = new Size(40, 40);
            delItemButton.Tag = item;
            delItemButton.Click += DelItemButton_Click;

            itemPanel.Controls.Add(itemNameLabel);
            itemPanel.Controls.Add(itemPriceLabel);
            itemPanel.Controls.Add(addItemButton);
            itemPanel.Controls.Add(delItemButton);
            return itemPanel;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var item = (MenuItem)button.Tag;

            var existingItem = pesananList.FirstOrDefault(i => i.ID == item.ID);
            if (existingItem != null)
            {
                existingItem.Jumlah++;
            }
            else
            {
                item.Jumlah = 1;
                pesananList.Add(item);
            }

            totalHarga += item.Harga;
            UpdatePesananPanel();
            lblTotalHarga.Text = $"Total Harga: Rp {totalHarga:N2}";
        }

        private void DelItemButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var item = (MenuItem)button.Tag;

            var existingItem = pesananList.FirstOrDefault(i => i.ID == item.ID);
            if (existingItem != null)
            {
                if (existingItem.Jumlah > 1)
                {
                    existingItem.Jumlah--;
                }
                else
                {
                    pesananList.Remove(existingItem);
                }

                totalHarga -= item.Harga;
                UpdatePesananPanel();
                lblTotalHarga.Text = $"Total Harga: Rp {totalHarga:N2}";
            }
        }

        private void UpdatePesananPanel()
        {
            panelPesanan.Controls.Clear();
            foreach (var item in pesananList)
            {
                Label itemLabel = new Label();
                itemLabel.Text = $"{item.Nama} x{item.Jumlah}";
                itemLabel.Size = new Size(140, 80);
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

            string namaPelanggan = txtNamaPelanggan.Text;
            string noTelp = txtNoTelp.Text;
            int metodePembayaranID = (int)comboMetodePembayaran.SelectedValue;
            int karyawanID;

            if (string.IsNullOrWhiteSpace(namaPelanggan) ||
                string.IsNullOrWhiteSpace(noTelp) ||
                !int.TryParse(txtKaryawanID.Text, out karyawanID))
            {
                MessageBox.Show("Nama Pelanggan, No Telp, dan ID Karyawan harus diisi dengan benar!");
                return;
            }

            int pelangganID = controller.GetOrCreatePelanggan(namaPelanggan, noTelp);

            Pesanan pesanan = new Pesanan
            {
                TanggalPemesanan = DateTime.Now,
                TotalHarga = totalHarga,
                TotalTax = totalHarga * 0.1m,
                PelangganID = pelangganID,
                MetodePembayaranID = metodePembayaranID,
                KaryawanID = karyawanID,
                Items = pesananList
            };

            try
            {
                controller.SubmitPesanan(pesanan);
                MessageBox.Show("Pesanan berhasil ditambahkan");
                pesananList.Clear();
                totalHarga = 0;
                lblTotalHarga.Text = $"Total Harga: Rp {totalHarga:N2}";
                UpdatePesananPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void LoadMetodePembayaran()
        {
            var metodePembayaran = controller.GetMetodePembayaran();
            comboMetodePembayaran.DataSource = metodePembayaran;
            comboMetodePembayaran.DisplayMember = "Nama";
            comboMetodePembayaran.ValueMember = "ID";
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            waiter_homepage homePage = new waiter_homepage();
            homePage.Show();
            this.Close();
        }

        private void txtKaryawanID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
