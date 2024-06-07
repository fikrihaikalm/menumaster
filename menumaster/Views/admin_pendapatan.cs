using System;
using System.Collections.Generic;
using System.Windows.Forms;
using menumaster.Controllers;
using menumaster.Models;

namespace menumaster.Views
{
    public partial class admin_pendapatan : Form
    {
        private DateTime tanggal1;
        private DateTime tanggal2;

        private DateOnly tanggalawal;
        private DateOnly tanggalakhir;

        private AdminPendapatanController _controller;

        public admin_pendapatan()
        {
            InitializeComponent();
            _controller = new AdminPendapatanController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page adminPage = new admin_page();
            adminPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tanggal1 = dateTimePicker1.Value;
            tanggalawal = DateOnly.FromDateTime(tanggal1);

            tanggal2 = dateTimePicker2.Value;
            tanggalakhir = DateOnly.FromDateTime(tanggal2);

            try
            {
                List<Pendapatan> pendapatanList = _controller.GetPendapatanData(tanggalawal, tanggalakhir);
                dataGridView1.DataSource = pendapatanList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void admin_pendapatan_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
