﻿using System;
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
    public partial class Login_admin : Form
    {
        public Login_admin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
/*            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();*/

            //string adminID = textBox1.Text;
            //string adminPassword = textBox2.Text;

            //if (adminID == "admin" && adminPassword == "password")
            //{
            // Login berhasil, buka form AdminDashboard



            //}

            //else
            //{
            // Login gagal, tampilkan pesan kesalahan
            //    MessageBox.Show("ID atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePageForm f1 = new WelcomePageForm();
            f1.Show();
            this.Close();
        }

        private void Login_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
