using menumaster.Forms;
using menumaster.Controllers;
using System;
using System.Windows.Forms;

namespace menumaster
{
    public partial class Login_manajer : Form
    {
        public static int KaryawanID { get; private set; }
        private readonly LoginManajerController _controller;

        public Login_manajer()
        {
            InitializeComponent();
            _controller = new LoginManajerController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("ID dan password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idKaryawan;
            if (!int.TryParse(textBox1.Text, out idKaryawan))
            {
                MessageBox.Show("ID karyawan harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var result = _controller.AuthenticateUser(idKaryawan, textBox2.Text);

                if (result.HasValue)
                {
                    // Simpan ID karyawan
                    KaryawanID = idKaryawan;

                    // ID, password valid dan role manager
                    Manager_Homepage homepage = new Manager_Homepage();
                    homepage.Show();
                    this.Close();
                }
                else
                {
                    // ID, password salah atau bukan role manager
                    MessageBox.Show("ID, password salah atau bukan role manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePageForm f1 = new WelcomePageForm();
            f1.Show();
            this.Close();
        }

        private void Login_manajer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
