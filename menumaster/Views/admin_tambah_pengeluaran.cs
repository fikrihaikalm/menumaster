using System;
using System.Data;
using System.Windows.Forms;
using menumaster.Controllers;
using menumaster.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace menumaster.Views
{
    public partial class Admin_tambah_pengeluaran : Form
    {
        private readonly Pengeluaran1Controller _controller;

        public Admin_tambah_pengeluaran()
        {
            InitializeComponent();
            _controller = new Pengeluaran1Controller();
        }

        private void PopulateComboBox()
        {
            DataTable jenisPengeluaranData = _controller.GetJenisPengeluaran();
            comboBox1.DataSource = jenisPengeluaranData;
            comboBox1.DisplayMember = "nama_pengeluaran";
            comboBox1.ValueMember = "id_jenis_pengeluaran";
        }

        private void tambah_pengeluaran_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void tambah_pengeluaran_Activated(object sender, EventArgs e)
        {
            PopulateComboBox(); // Mengisi ulang combobox setiap kali form mendapatkan fokus
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page adminPage = new admin_page();
            adminPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_tambah_jenis jenis = new Admin_tambah_jenis();
            jenis.FormClosed += new FormClosedEventHandler(tambah_pengeluaran_Activated);
            jenis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pengeluaran1Model pengeluaran = new Pengeluaran1Model
                {
                    IdJenisPengeluaran = (int)comboBox1.SelectedValue,
                    TanggalPengeluaran = dateTimePicker1.Value,
                    JumlahPengeluaran = decimal.Parse(textBox2.Text),
                    IdKaryawan = Login_admin.KaryawanID // Menggunakan ID karyawan yang login
                };

                bool isSuccess = _controller.TambahPengeluaran(pengeluaran);

                if (isSuccess)
                {
                    MessageBox.Show("Pengeluaran berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button3_Click(sender, e); // Clear the form
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan pengeluaran", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
