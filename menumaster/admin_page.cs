using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menumaster
{
    public partial class admin_page : Form
    {
        public admin_page()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            pengeluaran p1 = new pengeluaran();
            p1.Show();
            this.Close();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            pendapatan p2 = new pendapatan();
            p2.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            kelola_menu km = new kelola_menu();
            km.Show();
            this.Close();
        }
    }
}
