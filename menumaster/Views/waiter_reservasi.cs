using menumaster.Controllers;
using menumaster.Views;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace menumaster.Forms.Waiters
{
    public partial class waiter_reservasi : Form
    {
        private WaiterReservasiController controller;

        public waiter_reservasi()
        {
            InitializeComponent();
            this.dateTimePickerTanggal.CalendarForeColor = Color.Aqua;
            controller = new WaiterReservasiController();
        }

        private void waiters_pemesanan_Load(object sender, EventArgs e)
        {
            LoadMeja();
            LoadMetodePembayaran();
        }

        private void LoadMeja()
        {
            DataTable mejaData = controller.LoadMeja();
            foreach (DataRow row in mejaData.Rows)
            {
                int idMeja = Convert.ToInt32(row["ID_meja"]);
                int nomerMeja = Convert.ToInt32(row["nomer_meja"]);
                comboBoxMeja.Items.Add(new ComboBoxItem { Text = nomerMeja.ToString(), Value = idMeja });
            }
        }

        private void LoadMetodePembayaran()
        {
            DataTable metodePembayaranData = controller.LoadMetodePembayaran();
            foreach (DataRow row in metodePembayaranData.Rows)
            {
                int idMetode = Convert.ToInt32(row["ID_metode_pembayaran"]);
                string namaMetode = row["nama_metode"].ToString();
                comboBoxMetodePembayaran.Items.Add(new ComboBoxItem { Text = namaMetode, Value = idMetode });
            }
        }

        private int GetPelangganIdByTelp(string telp)
        {
            return controller.GetPelangganIdByTelp(telp);
        }

        private int AddNewPelanggan(string nama, string telp)
        {
            return controller.AddNewPelanggan(nama, telp);
        }

        private int GetAvailableMejaId(int jumlahOrang)
        {
            return controller.GetAvailableMejaId(jumlahOrang);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            waiter_homepage homePage = new waiter_homepage();
            homePage.Show();
            this.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            int pelangganId = GetPelangganIdByTelp(textBoxTelp.Text);

            if (pelangganId == -1)
            {
                // Pelanggan tidak ditemukan, tambahkan pelanggan baru
                pelangganId = AddNewPelanggan(textBoxNama.Text, textBoxTelp.Text);
            }

            int jumlahOrang = Convert.ToInt32(numericUpDownJumlahOrang.Value);
            int mejaId = GetAvailableMejaId(jumlahOrang);

            if (mejaId == -1)
            {
                MessageBox.Show("Tidak ada meja yang tersedia untuk jumlah orang yang diminta.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan durasiReservasi = TimeSpan.FromHours((double)numericUpDownDurasi.Value);
            TimeSpan waktuReservasi = TimeSpan.FromHours((double)numericUpDownWaktu.Value);

            controller.AddReservasiMeja(dateTimePickerTanggal.Value, waktuReservasi, durasiReservasi, jumlahOrang, mejaId, pelangganId);

            DialogResult result = MessageBox.Show("Reservasi sudah dibuat", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide(); // Menyembunyikan form saat ini
                waiter_homepage homePage = new waiter_homepage();
                homePage.Show(); // Menampilkan form HomePage
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

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMeja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownDurasi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownWaktu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownJumlahOrang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LabelMeja_Click(object sender, EventArgs e)
        {

        }
    }
}

