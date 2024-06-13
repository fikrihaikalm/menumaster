using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using menumaster.Controllers;

namespace menumaster.Views
{
    public partial class admin_kelolamenu : Form
    {
        private readonly AdminMenuController _menuController;
        private HashSet<int> editedRows;

        public admin_kelolamenu()
        {
            InitializeComponent();
            _menuController = new AdminMenuController();
            editedRows = new HashSet<int>();
            LoadData();
            PopulateComboBox();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            button5.Click += button5_Click_1;  // Ensure the event handler is assigned
        }

        private void PopulateComboBox()
        {
            DataTable categories = _menuController.GetCategories();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "kategori";
            comboBox1.ValueMember = "id_kategori";
        }

        private void admin_kelolamenu_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _menuController.GetMenuData();
                dataGridView1.DataSource = dt;

                // Make the DataGridView editable
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.ReadOnly = false;
                }
                // Set id_menu column to read-only because it is the primary key
                dataGridView1.Columns["id_menu"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["menu"].Value.ToString();
                textBox2.Text = selectedRow.Cells["harga"].Value.ToString();
                textBox3.Text = selectedRow.Cells["deskripsi"].Value.ToString();
                comboBox1.SelectedValue = selectedRow.Cells["id_kategori"].Value;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editedRows.Add(e.RowIndex);
                Console.WriteLine("Row edited: " + e.RowIndex);  // Debug message
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string namaMenu = textBox1.Text;
            decimal hargaMenu;
            if (!decimal.TryParse(textBox2.Text, out hargaMenu))
            {
                MessageBox.Show("Harga harus berupa angka");
                return;
            }
            string deskripsiMenu = textBox3.Text;
            int jenisKategori = (int)comboBox1.SelectedValue;

            try
            {
                _menuController.AddMenu(namaMenu, hargaMenu, deskripsiMenu, jenisKategori);
                MessageBox.Show("Berhasil!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                //MessageBox.Show("Pilih baris yang ingin diupdate.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idMenu = Convert.ToInt32(selectedRow.Cells["id_menu"].Value);
            string namaMenu = textBox1.Text;
            decimal hargaMenu;
            if (!decimal.TryParse(textBox2.Text, out hargaMenu))
            {
                MessageBox.Show("Harga harus berupa angka.");
                return;
            }
            string deskripsiMenu = textBox3.Text;
            int jenisKategori = (int)comboBox1.SelectedValue;

            try
            {
                _menuController.UpdateMenu(idMenu, namaMenu, hargaMenu, deskripsiMenu, jenisKategori);
                MessageBox.Show("Data berhasil diupdate!");
                LoadData(); // Refresh data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
