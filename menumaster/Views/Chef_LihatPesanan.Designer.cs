namespace menumaster.Views
{
    partial class LihatPesanan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatPesanan));
            dgvPesanan = new DataGridView();
            btnBack = new Button();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPesanan
            // 
            dgvPesanan.Anchor = AnchorStyles.None;
            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesanan.BackgroundColor = SystemColors.ControlLight;
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Location = new Point(44, 88);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.RowHeadersWidth = 82;
            dgvPesanan.Size = new Size(1280, 608);
            dgvPesanan.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.DarkSlateBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(20, 702);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(186, 71);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(34, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 59);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Lihat Pesanan";
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
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LihatPesanan
            // 
            ClientSize = new Size(1367, 788);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Controls.Add(dgvPesanan);
            MinimumSize = new Size(1385, 814);
            Name = "LihatPesanan";
            Text = "Lihat Pesanan";
            WindowState = FormWindowState.Maximized;
            Load += LihatPesanan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}
