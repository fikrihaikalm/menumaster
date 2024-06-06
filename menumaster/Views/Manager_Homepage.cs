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

namespace menumaster.Forms
{
    public partial class Manager_Homepage : Form
    {
        public Manager_Homepage()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Manager_KelolaKaryawan f2 = new Manager_KelolaKaryawan();
            f2.Show();
            this.Hide();
        }
        private void Manager_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
