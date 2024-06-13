using menumaster.Views;

namespace menumaster
{
    public partial class WelcomePageForm : Form
    {
        public WelcomePageForm()
        {
            InitializeComponent();
        }

/*        private void adminButton_Click(object sender, EventArgs e)
        {
            Login_admin f2 = new Login_admin();
            f2.Show();
            this.Hide();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            Login_manajer form3 = new Login_manajer();
            form3.Show();
            this.Hide();
        }*/

        private void kasirButton_Click(object sender, EventArgs e)
        {
            Login_kasir f4 = new Login_kasir();
            f4.Show();
            this.Hide();
        }

        private void welcomePageCardManager_Load(object sender, EventArgs e)
        {

        }

        private void WelcomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void welcomePageCardButton1_Load(object sender, EventArgs e)
        {

        }

        private void chefButton_Click(object sender, EventArgs e)
        {
            LihatPesanan f4 = new LihatPesanan();
            f4.Show();
            this.Hide();
        }
    }
}
