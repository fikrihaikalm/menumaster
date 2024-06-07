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
            dgvPesanan = new DataGridView();
            btnBack = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            SuspendLayout();
            // 
            // dgvPesanan
            // 
            dgvPesanan.Anchor = AnchorStyles.None;
            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesanan.BackgroundColor = Color.Azure;
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Location = new Point(34, 88);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.RowHeadersWidth = 82;
            dgvPesanan.Size = new Size(1280, 608);
            dgvPesanan.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Location = new Point(34, 702);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 59);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(34, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 59);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Lihat Pesanan";
            // 
            // LihatPesanan
            // 
            ClientSize = new Size(1346, 788);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Controls.Add(dgvPesanan);
            Name = "LihatPesanan";
            Text = "Lihat Pesanan";
            Load += LihatPesanan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}