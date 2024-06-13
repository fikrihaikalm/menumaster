using System.Reflection.Emit;
using System.Windows.Forms;

namespace menumaster.Views
{
    partial class waiter_pesanan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waiter_pesanan));
            buttonMakanan = new Button();
            buttonMinuman = new Button();
            buttonSnack = new Button();
            panelItems = new FlowLayoutPanel();
            panelPesanan = new FlowLayoutPanel();
            submitButton = new Button();
            txtNamaPelanggan = new TextBox();
            txtNoTelp = new TextBox();
            comboMetodePembayaran = new ComboBox();
            txtKaryawanID = new TextBox();
            lblNamaPelanggan = new System.Windows.Forms.Label();
            lblNoTelp = new System.Windows.Forms.Label();
            lblMetodePembayaran = new System.Windows.Forms.Label();
            lblKaryawanID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblTotalHarga = new System.Windows.Forms.Label();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonMakanan
            // 
            buttonMakanan.Anchor = AnchorStyles.None;
            buttonMakanan.Font = new Font("Segoe UI", 13.8F);
            buttonMakanan.Location = new Point(297, 12);
            buttonMakanan.Name = "buttonMakanan";
            buttonMakanan.Size = new Size(133, 46);
            buttonMakanan.TabIndex = 0;
            buttonMakanan.Text = "Makanan";
            buttonMakanan.UseVisualStyleBackColor = true;
            buttonMakanan.Click += ButtonMakanan_Click;
            // 
            // buttonMinuman
            // 
            buttonMinuman.Anchor = AnchorStyles.None;
            buttonMinuman.Font = new Font("Segoe UI", 13.8F);
            buttonMinuman.Location = new Point(476, 12);
            buttonMinuman.Name = "buttonMinuman";
            buttonMinuman.Size = new Size(146, 46);
            buttonMinuman.TabIndex = 1;
            buttonMinuman.Text = "Minuman";
            buttonMinuman.UseVisualStyleBackColor = true;
            buttonMinuman.Click += ButtonMinuman_Click;
            // 
            // buttonSnack
            // 
            buttonSnack.Anchor = AnchorStyles.None;
            buttonSnack.Font = new Font("Segoe UI", 13.8F);
            buttonSnack.Location = new Point(681, 12);
            buttonSnack.Name = "buttonSnack";
            buttonSnack.Size = new Size(117, 46);
            buttonSnack.TabIndex = 2;
            buttonSnack.Text = "Snack";
            buttonSnack.UseVisualStyleBackColor = true;
            buttonSnack.Click += ButtonSnack_Click;
            // 
            // panelItems
            // 
            panelItems.Anchor = AnchorStyles.None;
            panelItems.AutoScroll = true;
            panelItems.Font = new Font("Segoe UI", 13.8F);
            panelItems.Location = new Point(18, 84);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(862, 500);
            panelItems.TabIndex = 3;
            // 
            // panelPesanan
            // 
            panelPesanan.Anchor = AnchorStyles.None;
            panelPesanan.AutoScroll = true;
            panelPesanan.Font = new Font("Segoe UI", 13.8F);
            panelPesanan.Location = new Point(923, 69);
            panelPesanan.Name = "panelPesanan";
            panelPesanan.Size = new Size(401, 515);
            panelPesanan.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.BackColor = SystemColors.GradientActiveCaption;
            submitButton.Font = new Font("Segoe UI", 13.8F);
            submitButton.Location = new Point(1143, 687);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(181, 61);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.Anchor = AnchorStyles.None;
            txtNamaPelanggan.Font = new Font("Segoe UI", 13.8F);
            txtNamaPelanggan.Location = new Point(625, 590);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(246, 44);
            txtNamaPelanggan.TabIndex = 6;
            // 
            // txtNoTelp
            // 
            txtNoTelp.Anchor = AnchorStyles.None;
            txtNoTelp.Font = new Font("Segoe UI", 13.8F);
            txtNoTelp.Location = new Point(625, 641);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(246, 44);
            txtNoTelp.TabIndex = 7;
            // 
            // comboMetodePembayaran
            // 
            comboMetodePembayaran.Anchor = AnchorStyles.None;
            comboMetodePembayaran.Font = new Font("Segoe UI", 13.8F);
            comboMetodePembayaran.Location = new Point(625, 693);
            comboMetodePembayaran.Name = "comboMetodePembayaran";
            comboMetodePembayaran.Size = new Size(246, 46);
            comboMetodePembayaran.TabIndex = 8;
            // 
            // txtKaryawanID
            // 
            txtKaryawanID.Anchor = AnchorStyles.None;
            txtKaryawanID.Location = new Point(20, 663);
            txtKaryawanID.Name = "txtKaryawanID";
            txtKaryawanID.Size = new Size(246, 31);
            txtKaryawanID.TabIndex = 43;
            txtKaryawanID.TextChanged += txtKaryawanID_TextChanged;
            // 
            // lblNamaPelanggan
            // 
            lblNamaPelanggan.Anchor = AnchorStyles.None;
            lblNamaPelanggan.AutoSize = true;
            lblNamaPelanggan.Font = new Font("Segoe UI", 13.8F);
            lblNamaPelanggan.Location = new Point(334, 593);
            lblNamaPelanggan.Name = "lblNamaPelanggan";
            lblNamaPelanggan.Size = new Size(227, 38);
            lblNamaPelanggan.TabIndex = 9;
            lblNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // lblNoTelp
            // 
            lblNoTelp.Anchor = AnchorStyles.None;
            lblNoTelp.AutoSize = true;
            lblNoTelp.Font = new Font("Segoe UI", 13.8F);
            lblNoTelp.Location = new Point(334, 644);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(112, 38);
            lblNoTelp.TabIndex = 10;
            lblNoTelp.Text = "No Telp";
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.Anchor = AnchorStyles.None;
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.Font = new Font("Segoe UI", 13.8F);
            lblMetodePembayaran.Location = new Point(334, 696);
            lblMetodePembayaran.Name = "lblMetodePembayaran";
            lblMetodePembayaran.Size = new Size(273, 38);
            lblMetodePembayaran.TabIndex = 11;
            lblMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // lblKaryawanID
            // 
            lblKaryawanID.Anchor = AnchorStyles.None;
            lblKaryawanID.Location = new Point(36, 44);
            lblKaryawanID.Name = "lblKaryawanID";
            lblKaryawanID.Size = new Size(100, 24);
            lblKaryawanID.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(18, 602);
            label1.Name = "label1";
            label1.Size = new Size(170, 38);
            label1.TabIndex = 12;
            label1.Text = "Karyawan ID";
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.Anchor = AnchorStyles.None;
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Segoe UI", 13.8F);
            lblTotalHarga.Location = new Point(923, 602);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(195, 38);
            lblTotalHarga.TabIndex = 14;
            lblTotalHarga.Text = "TOTAL HARGA";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.DarkSlateBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(20, 719);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 54);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.ep_back;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 739);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // waiter_pesanan
            // 
            ClientSize = new Size(1367, 785);
            Controls.Add(lblKaryawanID);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(lblTotalHarga);
            Controls.Add(label1);
            Controls.Add(lblMetodePembayaran);
            Controls.Add(lblNoTelp);
            Controls.Add(lblNamaPelanggan);
            Controls.Add(txtKaryawanID);
            Controls.Add(comboMetodePembayaran);
            Controls.Add(txtNoTelp);
            Controls.Add(txtNamaPelanggan);
            Controls.Add(submitButton);
            Controls.Add(buttonSnack);
            Controls.Add(buttonMinuman);
            Controls.Add(buttonMakanan);
            Controls.Add(panelItems);
            Controls.Add(panelPesanan);
            MinimumSize = new Size(1385, 814);
            Name = "waiter_pesanan";
            Text = "Waiter Pesanan";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonMakanan;
        private System.Windows.Forms.Button buttonMinuman;
        private System.Windows.Forms.Button buttonSnack;
        private System.Windows.Forms.FlowLayoutPanel panelItems;
        private System.Windows.Forms.FlowLayoutPanel panelPesanan;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.ComboBox comboMetodePembayaran;
        private System.Windows.Forms.TextBox txtKaryawanID;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Label lblMetodePembayaran;
        private System.Windows.Forms.Label lblKaryawanID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

