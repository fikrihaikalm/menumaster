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
            Login_admin f2 = new Login_admin();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_manajer form3 = new Login_manajer();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
