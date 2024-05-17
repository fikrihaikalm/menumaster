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
    public partial class Login_manajer : Form
    {
        public Login_manajer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
