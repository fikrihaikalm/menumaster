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

        private void button1_Click(object sender, EventArgs e)
        {
            Pengeluaran pengeluaran = new Pengeluaran();
            pengeluaran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Buka form Pendapatan
            Pendapatan pendapatan = new Pendapatan();
            pendapatan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Buka form Kelola Menu
            kelolamenu kelolamenu = new kelolamenu();
            kelolamenu.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pendapatan pendapatan = new Pendapatan();
            pendapatan.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kelolamenu kelolamenu = new kelolamenu();
            kelolamenu.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void admin_page_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
