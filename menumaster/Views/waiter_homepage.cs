using menumaster.Forms.Waiters;
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
    public partial class waiter_homepage : Form
    {
        public waiter_homepage()
        {
            InitializeComponent();

        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            waiter_pesanan pesanan = new waiter_pesanan();
            pesanan.Show();
            this.Close();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            waiter_reservasi reservasi = new waiter_reservasi();
            reservasi.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            WelcomePageForm welcome = new WelcomePageForm();
            welcome.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waiter_pesanan wp = new waiter_pesanan();
            wp.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            waiter_reservasi wr = new waiter_reservasi();
            wr.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomePageForm welcome = new WelcomePageForm();
            welcome.Show();
            this.Close();
        }

        private void waiter_homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
