using System;
using System.Data;
using System.Windows.Forms;
using menumaster.Controllers;

namespace menumaster.Views
{
    public partial class LihatPesanan : Form
    {
        private readonly LihatPesananController _controller;

        public LihatPesanan()
        {
            InitializeComponent();
            _controller = new LihatPesananController();
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
            DataTable dt = _controller.GetPesananData();
            dgvPesanan.DataSource = dt;
        }
    }
}
