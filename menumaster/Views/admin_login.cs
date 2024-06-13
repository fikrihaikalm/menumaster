using menumaster.Controllers;
using System;
using System.Windows.Forms;

namespace menumaster.Views
{
    public partial class Login_admin : Form
    {
        public static int KaryawanID { get; private set; }
        private LoginController _loginController;

        public Login_admin()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string passwordtxt = textBox2.Text; // Assuming textBox2 is for password

            if (int.TryParse(username, out int id_karyawan))
            {
                try
                {
                    int? karyawanID = _loginController.AuthenticateUser(id_karyawan, passwordtxt);

                    if (karyawanID.HasValue)
                    {
                        KaryawanID = karyawanID.Value; // Save the employee ID
                        MessageBox.Show("Login berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        admin_page homepage = new admin_page();
                        homepage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ID, password salah atau bukan role admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID karyawan harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePageForm f1 = new WelcomePageForm();
            f1.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
