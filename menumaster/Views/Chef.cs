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
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Chef_Load(object sender, EventArgs e)
        {

        }

        private void btnLihatPesanan_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Menampilkan pesanan.");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            chef_login f1 = new chef_login();
            f1.Show();
            this.Close();

        }
    }
}
    