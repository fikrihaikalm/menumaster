using menumaster.Views;
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
            this.Tanggal.CalendarForeColor = Color.Aqua;
        }

        private void waiters_pemesanan_Load(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reservasi sudah dibuat", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide(); // Menyembunyikan form saat ini
                waiter_homepage homePage = new waiter_homepage();
                homePage.Show(); // Menampilkan form HomePage
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            waiter_homepage homePage = new waiter_homepage();
            homePage.Show(); 
            this.Close();
        }
    }
}