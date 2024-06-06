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
            SuspendLayout();
            // 
            // buttonMakanan
            // 
            buttonMakanan.Location = new Point(12, 12);
            buttonMakanan.Name = "buttonMakanan";
            buttonMakanan.Size = new Size(133, 46);
            buttonMakanan.TabIndex = 0;
            buttonMakanan.Text = "Makanan";
            buttonMakanan.UseVisualStyleBackColor = true;
            buttonMakanan.Click += ButtonMakanan_Click;
            // 
            // buttonMinuman
            // 
            buttonMinuman.Location = new Point(184, 12);
            buttonMinuman.Name = "buttonMinuman";
            buttonMinuman.Size = new Size(146, 46);
            buttonMinuman.TabIndex = 1;
            buttonMinuman.Text = "Minuman";
            buttonMinuman.UseVisualStyleBackColor = true;
            buttonMinuman.Click += ButtonMinuman_Click;
            // 
            // buttonSnack
            // 
            buttonSnack.Location = new Point(385, 12);
            buttonSnack.Name = "buttonSnack";
            buttonSnack.Size = new Size(117, 46);
            buttonSnack.TabIndex = 2;
            buttonSnack.Text = "Snack";
            buttonSnack.UseVisualStyleBackColor = true;
            buttonSnack.Click += ButtonSnack_Click;
            // 
            // panelItems
            // 
            panelItems.Location = new Point(13, 84);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(862, 500);
            panelItems.TabIndex = 3;
            // 
            // panelPesanan
            // 
            panelPesanan.Location = new Point(918, 69);
            panelPesanan.Name = "panelPesanan";
            panelPesanan.Size = new Size(401, 612);
            panelPesanan.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(1109, 687);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(210, 61);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // txtPelangganID
            // 
            txtPelangganID.Location = new Point(304, 595);
            txtPelangganID.Name = "txtPelangganID";
            txtPelangganID.Size = new Size(100, 39);
            txtPelangganID.TabIndex = 6;
            // 
            // txtMetodePembayaranID
            // 
            txtMetodePembayaranID.Location = new Point(304, 646);
            txtMetodePembayaranID.Name = "txtMetodePembayaranID";
            txtMetodePembayaranID.Size = new Size(100, 39);
            txtMetodePembayaranID.TabIndex = 7;
            // 
            // txtKaryawanID
            // 
            txtKaryawanID.Location = new Point(304, 698);
            txtKaryawanID.Name = "txtKaryawanID";
            txtKaryawanID.Size = new Size(100, 39);
            txtKaryawanID.TabIndex = 8;
            // 
            // lblPelangganID
            // 
            lblPelangganID.AutoSize = true;
            lblPelangganID.Location = new Point(13, 598);
            lblPelangganID.Name = "lblPelangganID";
            lblPelangganID.Size = new Size(155, 32);
            lblPelangganID.TabIndex = 9;
            lblPelangganID.Text = "Pelanggan ID";
            // 
            // lblMetodePembayaranID
            // 
            lblMetodePembayaranID.AutoSize = true;
            lblMetodePembayaranID.Location = new Point(12, 649);
            lblMetodePembayaranID.Name = "lblMetodePembayaranID";
            lblMetodePembayaranID.Size = new Size(265, 32);
            lblMetodePembayaranID.TabIndex = 10;
            lblMetodePembayaranID.Text = "Metode Pembayaran ID";
            // 
            // lblKaryawanID
            // 
/*            lblKaryawanID.AutoSize = true;
            lblKaryawanID.Location = new Point(13, 587);
            lblKaryawanID.Name = "lblKaryawanID";
            lblKaryawanID.Size = new Size(0, 32);
            lblKaryawanID.TabIndex = 11;
            lblKaryawanID.Click += lblKaryawanID_Click;*/
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 701);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 12;
            label1.Text = "Karyawan ID";
            // 
            // waiter_pesanan
            // 
            ClientSize = new Size(1360, 785);
            Controls.Add(label1);
            Controls.Add(lblKaryawanID);
            Controls.Add(lblMetodePembayaranID);
            Controls.Add(lblPelangganID);
            Controls.Add(txtKaryawanID);
            Controls.Add(txtMetodePembayaranID);
            Controls.Add(txtPelangganID);
            Controls.Add(submitButton);
            Controls.Add(panelPesanan);
            Controls.Add(panelItems);
            Controls.Add(buttonSnack);
            Controls.Add(buttonMinuman);
            Controls.Add(buttonMakanan);
            MaximumSize = new Size(1386, 856);
            MinimumSize = new Size(994, 736);
            Name = "waiter_pesanan";
            Text = "Waiter Pesanan";
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
    }
}
