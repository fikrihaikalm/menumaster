using System;
using System.Data;
using System.Windows.Forms;
using menumaster.Controllers;
using menumaster.Forms;

namespace menumaster.Views
{
    public partial class LaporanKeuanganForm : Form
    {
        private readonly LaporanKeuanganController _controller;

        public LaporanKeuanganForm()
        {
            InitializeComponent();
            _controller = new LaporanKeuanganController();
        }

        private void LaporanKeuanganForm_Load(object sender, EventArgs e)
        {
            LoadLaporanKeuangan(DateTime.Now);
        }

        private void DtpPeriode_ValueChanged(object sender, EventArgs e)
        {
            LoadLaporanKeuangan(dtpPeriode.Value);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Manager_Homepage home = new Manager_Homepage();
            home.Show();
            this.Close();
        }

        private void LoadLaporanKeuangan(DateTime tanggal)
        {
            DataTable dt = _controller.GetLaporanKeuangan(tanggal);
            dgvLaporan.DataSource = dt;
        }

        private void dgvLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
