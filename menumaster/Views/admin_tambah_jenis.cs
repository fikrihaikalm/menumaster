using System;
using System.Windows.Forms;
using menumaster.Controllers;
using menumaster.Models;

namespace menumaster.Views
{
    public partial class Admin_tambah_jenis : Form
    {
        private readonly JenisPengeluaranController _controller;

        public Admin_tambah_jenis()
        {
            InitializeComponent();
            _controller = new JenisPengeluaranController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenisPengeluaran = textBox1.Text;
            JenisPengeluaran jenis = new JenisPengeluaran { NamaPengeluaran = jenisPengeluaran };

            try
            {
                bool isSuccess = _controller.TambahJenisPengeluaran(jenis);

                if (isSuccess)
                {
                    textBox1.Clear();
                    this.Close(); // Menutup form setelah data berhasil disimpan
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan jenis pengeluaran", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
