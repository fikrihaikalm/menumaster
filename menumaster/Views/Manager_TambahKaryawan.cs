﻿using menumaster.Forms;
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
    public partial class Manager_TambahKaryawan : Form
    {
        public Manager_TambahKaryawan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_KelolaKaryawan f1 = new Manager_KelolaKaryawan();
            f1.Show();
            this.Close();
        }

        private void Manager_TambahKaryawan_Load(object sender, EventArgs e)
        {

        }
    }
}
