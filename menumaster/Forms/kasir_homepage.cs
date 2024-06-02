using System;
using System.Windows.Forms;
namespace menumaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnPesanMakanan = new Button();
            btnReservasi = new Button();
            SuspendLayout();
            // 
            // btnPesanMakanan
            // 
            btnPesanMakanan.BackColor = Color.SkyBlue;
            btnPesanMakanan.Location = new Point(100, 89);
            btnPesanMakanan.Name = "btnPesanMakanan";
            btnPesanMakanan.Size = new Size(200, 50);
            btnPesanMakanan.TabIndex = 0;
            btnPesanMakanan.Text = "Pesan Makanan";
            btnPesanMakanan.UseVisualStyleBackColor = false;
            btnPesanMakanan.Click += BtnPesanMakanan_Click;
            // 
            // btnReservasi
            // 
            btnReservasi.BackColor = Color.SkyBlue;
            btnReservasi.Location = new Point(100, 160);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(200, 50);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "Reservasi";
            btnReservasi.UseVisualStyleBackColor = false;
            btnReservasi.Click += BtnReservasi_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(416, 269);
            Controls.Add(btnPesanMakanan);
            Controls.Add(btnReservasi);
            Name = "Form1";
            Text = "Homepage Kasir";
            ResumeLayout(false);
        }

        private void BtnPesanMakanan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesan makanan button clicked");
        }

        private void BtnReservasi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservasi button clicked");
        }

        private Button btnPesanMakanan;
        private Button btnReservasi;
    }
}
