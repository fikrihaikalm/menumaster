﻿using System;
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
    public partial class waiter_pesanan : Form
    {
        public waiter_pesanan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pesanan sudah dibuat", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide(); // Menyembunyikan form saat ini
                waiter_homepage homePage = new waiter_homepage();
                homePage.Show(); // Menampilkan form HomePage
            }
        }
    }
}
