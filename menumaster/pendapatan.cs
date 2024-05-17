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
    public partial class pendapatan : Form
    {
        public pendapatan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page_admin pa = new page_admin();
            pa.Show();
            this.Close();
        }
    }
}
