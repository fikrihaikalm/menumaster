using System;
using System.Data;
using System.Windows.Forms;
using menumaster.Controllers;

namespace menumaster.Views
{
    public partial class Manager_UbahKaryawan : Form
    {
        private readonly UbahKaryawanController _controller;
        private int _idKaryawan;

        public Manager_UbahKaryawan(int idKaryawan)
        {
            InitializeComponent();
            _controller = new UbahKaryawanController();
            _idKaryawan = idKaryawan;
        }

        private void Manager_UbahKaryawan_Load(object sender, EventArgs e)
        {
            LoadKaryawanData(_idKaryawan);
        }

        private void LoadKaryawanData(int idKaryawan)
        {
            DataRow karyawan = _controller.GetKaryawanById(idKaryawan);
            if (karyawan != null)
            {
                textBox1.Text = karyawan["id_karyawan"].ToString();
                textBox2.Text = karyawan["nama"].ToString();
                textBox3.Text = karyawan["telp"].ToString();
                checkBoxAktif.Checked = (bool)karyawan["aktif"];
            }
            else
            {
                MessageBox.Show("Karyawan tidak ditemukan.");
                this.Close();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                int idKaryawan = _idKaryawan;
                string nama = textBox2.Text;
                int telp = int.Parse(textBox3.Text);
                bool aktif = checkBoxAktif.Checked;

                _controller.UbahKaryawan(idKaryawan, nama, telp, aktif);

                MessageBox.Show("Data karyawan berhasil diubah.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Logika untuk tombol "Batal"
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
