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
            txtPelangganID = new TextBox();
            txtMetodePembayaranID = new TextBox();
            txtKaryawanID = new TextBox();
            lblPelangganID = new Label();
            lblMetodePembayaranID = new Label();
            lblKaryawanID = new Label();
            label1 = new Label();
            lblTotalHarga = new Label();
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
            // txtPelangganID
            // 
            txtPelangganID.Anchor = AnchorStyles.None;
            txtPelangganID.Font = new Font("Segoe UI", 13.8F);
            txtPelangganID.Location = new Point(634, 602);
            txtPelangganID.Name = "txtPelangganID";
            txtPelangganID.Size = new Size(246, 38);
            txtPelangganID.TabIndex = 6;
            // 
            // txtMetodePembayaranID
            // 
            txtMetodePembayaranID.Anchor = AnchorStyles.None;
            txtMetodePembayaranID.Font = new Font("Segoe UI", 13.8F);
            txtMetodePembayaranID.Location = new Point(634, 653);
            txtMetodePembayaranID.Name = "txtMetodePembayaranID";
            txtMetodePembayaranID.Size = new Size(246, 38);
            txtMetodePembayaranID.TabIndex = 7;
            // 
            // txtKaryawanID
            // 
            txtKaryawanID.Anchor = AnchorStyles.None;
            txtKaryawanID.Font = new Font("Segoe UI", 13.8F);
            txtKaryawanID.Location = new Point(634, 705);
            txtKaryawanID.Name = "txtKaryawanID";
            txtKaryawanID.Size = new Size(246, 38);
            txtKaryawanID.TabIndex = 8;
            // 
            // lblPelangganID
            // 
            lblPelangganID.Anchor = AnchorStyles.None;
            lblPelangganID.AutoSize = true;
            lblPelangganID.Font = new Font("Segoe UI", 13.8F);
            lblPelangganID.Location = new Point(343, 605);
            lblPelangganID.Name = "lblPelangganID";
            lblPelangganID.Size = new Size(150, 31);
            lblPelangganID.TabIndex = 9;
            lblPelangganID.Text = "Pelanggan ID";
            // 
            // lblMetodePembayaranID
            // 
            lblMetodePembayaranID.Anchor = AnchorStyles.None;
            lblMetodePembayaranID.AutoSize = true;
            lblMetodePembayaranID.Font = new Font("Segoe UI", 13.8F);
            lblMetodePembayaranID.Location = new Point(342, 656);
            lblMetodePembayaranID.Name = "lblMetodePembayaranID";
            lblMetodePembayaranID.Size = new Size(254, 31);
            lblMetodePembayaranID.TabIndex = 10;
            lblMetodePembayaranID.Text = "Metode Pembayaran ID";
            // 
            // lblKaryawanID
            // 
            lblKaryawanID.Anchor = AnchorStyles.None;
            lblKaryawanID.Location = new Point(5, 0);
            lblKaryawanID.Name = "lblKaryawanID";
            lblKaryawanID.Size = new Size(100, 23);
            lblKaryawanID.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(343, 708);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
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
            lblTotalHarga.Size = new Size(159, 31);
            lblTotalHarga.TabIndex = 14;
            lblTotalHarga.Text = "TOTAL HARGA";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(lblTotalHarga);
            Controls.Add(label1);
            Controls.Add(lblKaryawanID);
            Controls.Add(lblMetodePembayaranID);
            Controls.Add(lblPelangganID);
            Controls.Add(txtKaryawanID);
            Controls.Add(txtMetodePembayaranID);
            Controls.Add(txtPelangganID);
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
        private System.Windows.Forms.TextBox txtPelangganID;
        private System.Windows.Forms.TextBox txtMetodePembayaranID;
        private System.Windows.Forms.TextBox txtKaryawanID;
        private System.Windows.Forms.Label lblPelangganID;
        private System.Windows.Forms.Label lblMetodePembayaranID;
        private System.Windows.Forms.Label lblKaryawanID;
        private Label label1;
        private Label lblTotalHarga;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}
