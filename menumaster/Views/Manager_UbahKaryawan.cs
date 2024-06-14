using System;
using System.Data;
using System.Windows.Forms;
using menumaster.Controllers;

namespace menumaster.Views
{
    public partial class Manager_UbahKaryawan : Form
    {
        private readonly ManagerUbahKaryawanController _controller;
        private int _idKaryawan;

        public Manager_UbahKaryawan(int idKaryawan)
        {
            InitializeComponent();
            _controller = new ManagerUbahKaryawanController();
            _idKaryawan = idKaryawan;
        }

        private void Manager_UbahKaryawan_Load(object sender, EventArgs e)
        {
            LoadKaryawanData(_idKaryawan);
            comboBoxRole.DataSource = _controller.GetRoles();
            comboBoxRole.DisplayMember = "RoleName";
            comboBoxRole.ValueMember = "RoleID";
        }

        private void LoadKaryawanData(int idKaryawan)
        {
            DataRow karyawan = _controller.GetKaryawanById(idKaryawan);
            if (karyawan != null)
            {
                textBoxID.Text = karyawan["id_karyawan"].ToString();
                textBoxNama.Text = karyawan["nama"].ToString();
                textBoxTelp.Text = karyawan["telp"].ToString();
                textBoxAlamat.Text = karyawan["alamat"].ToString();
                textBoxFoto.Text = karyawan["foto"].ToString();
                textBoxPassword.Text = karyawan["password"].ToString();
                textBoxEmail.Text = karyawan["email"].ToString();
                dateTimePickerTglMasuk.Value = Convert.ToDateTime(karyawan["tgl_masuk"]);
                textBoxGaji.Text = karyawan["gaji"].ToString();
                comboBoxRole.SelectedValue = karyawan["ID_role"];
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
                string telp = textBoxTelp.Text;
                string alamat = textBoxAlamat.Text;
                string foto = textBoxFoto.Text;
                bool aktif = checkBoxAktif.Checked;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                decimal gaji = decimal.Parse(textBoxGaji.Text);
                int idRole = (int)comboBoxRole.SelectedValue;

                _controller.UbahKaryawan(_idKaryawan, telp, alamat, foto, aktif, password, email, gaji, idRole);

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
            this.Close();
        }
    }
}
