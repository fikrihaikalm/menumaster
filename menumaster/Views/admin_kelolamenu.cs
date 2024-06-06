using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace menumaster
{
<<<<<<< HEAD:menumaster/Forms/kelolamenu.cs
    public partial class KelolaMenu : Form
    {
        public KelolaMenu()
=======
    public partial class admin_kelolamenu : Form
    {
        public admin_kelolamenu()
>>>>>>> dbeeba6735644caf6eb1d3cd33bfb5814de6869c:menumaster/Views/admin_kelolamenu.cs
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page admin_page = new admin_page();
            admin_page.Show();
            this.Hide();
        }
        private void LoadData()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1;Database=menu master";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM menu";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
