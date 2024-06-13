using System;
using System.Windows.Forms;
using menumaster.Controllers;

namespace menumaster.Views
{
    public partial class Manager_TambahKaryawan : Form
    {
        private readonly TambahKaryawanController _controller;

        public Manager_TambahKaryawan()
        {
            InitializeComponent();
            _controller = new TambahKaryawanController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_KelolaKaryawan f1 = new Manager_KelolaKaryawan();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNama.Text) || string.IsNullOrWhiteSpace(textBoxTelp.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAlamat.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxGaji.Text))
                {
                    MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nama = textBoxNama.Text;
                string telp = textBoxTelp.Text;
                string alamat = textBoxAlamat.Text;
                string foto = textBoxFoto.Text;
                bool aktif = checkBoxAktif.Checked;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                DateTime tglMasuk = dateTimePickerTglMasuk.Value;
                decimal gaji = decimal.Parse(textBoxGaji.Text);
                int idRole = (int)comboBoxRole.SelectedValue;

                _controller.TambahKaryawan(nama, telp, alamat, foto, aktif, password, email, tglMasuk, gaji, idRole);

                MessageBox.Show("Karyawan berhasil ditambahkan.");
                Manager_KelolaKaryawan kelolaKaryawan = new Manager_KelolaKaryawan();
                kelolaKaryawan.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Manager_TambahKaryawan_Load(object sender, EventArgs e)
        {
            // Load roles into comboBoxRole
            comboBoxRole.DataSource = _controller.GetRoles();
            comboBoxRole.DisplayMember = "RoleName"; // Assuming RoleName is the display field
            comboBoxRole.ValueMember = "RoleID"; // Assuming RoleID is the value field
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
