﻿using menumaster.Views;
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
    public partial class Login_kasir : Form
    {
        public Login_kasir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePageForm f1 = new WelcomePageForm();
            f1.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                waiter_homepage homepage = new waiter_homepage();
                homepage.Show();
                this.Close();
            }
        }
    }
}
