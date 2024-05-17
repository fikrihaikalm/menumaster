namespace menumaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Login_admin f2 = new Login_admin();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login_manajer form3 = new Login_manajer();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Login_kasir f4 = new Login_kasir();
            f4.Show();
        }
    }
}
