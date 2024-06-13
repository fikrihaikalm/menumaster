using menumaster.Forms;
using menumaster.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace menumaster.Views
{
    public partial class Manager_KelolaKaryawan : Form
    {
        private readonly KelolaKaryawanController _controller;

        public Manager_KelolaKaryawan()
        {
            InitializeComponent();
            _controller = new KelolaKaryawanController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Homepage f2 = new Manager_Homepage();
            f2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_TambahKaryawan f3 = new Manager_TambahKaryawan();
            f3.Show();
            this.Hide();
        }

        private void Manager_KelolaKaryawan_Load(object sender, EventArgs e)
        {
            LoadKaryawanData();
        }

        private void LoadKaryawanData()
        {
            try
            {
                DataTable dt = _controller.GetKaryawanData();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["id_karyawan"].Value);

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _controller.DeleteKaryawan(selectedId);
                        LoadKaryawanData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Harap pilih baris untuk dihapus.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadKaryawanData(textBox1.Text);
        }

        private void LoadKaryawanData(string searchKeyword)
        {
            try
            {
                DataTable dt = _controller.GetKaryawanData(searchKeyword);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadKaryawanData(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["id_karyawan"].Value);

                Manager_UbahKaryawan formUbah = new Manager_UbahKaryawan(selectedId);
                formUbah.ShowDialog();
                LoadKaryawanData();
            }
            else
            {
                MessageBox.Show("Harap pilih baris untuk diubah.");
            }
        }
    }
}
