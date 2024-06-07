using System;
using System.Data;
using System.Windows.Forms;
using menumaster.Helpers;
using Npgsql;

namespace menumaster.Views
{
    public partial class LihatPesanan : Form
    {
        public LihatPesanan()
        {
            InitializeComponent();
        }

        private void LihatPesanan_Load(object sender, EventArgs e)
        {
            LoadPesanan();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Implement back button logic
            WelcomePageForm wp = new WelcomePageForm();
            wp.Show();
            this.Close();
        }


        private void LoadPesanan()
        {
            string query = @"SELECT dp.ID_detail_pesanan as urutan_pesanan, p.tanggal_pemesanan, m.nama, dp.jumlah 
                            FROM detail_pesanan dp 
                            JOIN pesanan p ON dp.ID_pesanan = p.ID_pesanan 
                            JOIN menu m ON dp.ID_menu = m.ID_menu
                            where dp.jumlah > 0 ";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvPesanan.DataSource = dt;

        }
    }
}
