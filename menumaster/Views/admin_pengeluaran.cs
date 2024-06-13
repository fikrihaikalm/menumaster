using System;
using System.Collections.Generic;
using System.Windows.Forms;
using menumaster.Controllers;
using menumaster.Models;

namespace menumaster.Views
{
    public partial class admin_pengeluaran : Form
    {
        private DateTime tanggal1;
        private DateTime tanggal2;

        private DateOnly tanggalawal;
        private DateOnly tanggalakhir;

        private AdminPengeluaranController _controller;

        public admin_pengeluaran()
        {
            InitializeComponent();
            _controller = new AdminPengeluaranController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page adminPage = new admin_page();
            adminPage.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle combo box selection change if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void admin_pengeluaran_Load(object sender, EventArgs e)
        {
            // Load data when the form loads
            LoadPengeluaranData();
        }

        private void LoadPengeluaranData()
        {
            tanggal1 = dateTimePicker1.Value;
            tanggalawal = DateOnly.FromDateTime(tanggal1); // Only date, no time

            tanggal2 = dateTimePicker2.Value;
            tanggalakhir = DateOnly.FromDateTime(tanggal2); // Only date, no time

            try
            {
                List<Pengeluaran> pengeluaranList = _controller.GetPengeluaranData(tanggalawal, tanggalakhir);
                dataGridView1.DataSource = pengeluaranList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reload data based on the selected dates
            LoadPengeluaranData();
        }
    }
}
