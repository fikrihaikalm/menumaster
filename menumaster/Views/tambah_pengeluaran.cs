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
    public partial class tambah_pengeluaran : Form
    {
        public tambah_pengeluaran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();
        }
    }
}
