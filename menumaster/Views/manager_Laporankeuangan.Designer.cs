namespace menumaster.Views
{
    partial class LaporanKeuanganForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLaporanKeuangan;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.DateTimePicker dtpPeriode;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanKeuanganForm));
            lblLaporanKeuangan = new Label();
            lblPeriode = new Label();
            dtpPeriode = new DateTimePicker();
            dgvLaporan = new DataGridView();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLaporanKeuangan
            // 
            lblLaporanKeuangan.Anchor = AnchorStyles.None;
            lblLaporanKeuangan.AutoSize = true;
            lblLaporanKeuangan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLaporanKeuangan.Location = new Point(20, 38);
            lblLaporanKeuangan.Name = "lblLaporanKeuangan";
            lblLaporanKeuangan.Size = new Size(280, 41);
            lblLaporanKeuangan.TabIndex = 0;
            lblLaporanKeuangan.Text = "Laporan Keuangan";
            // 
            // lblPeriode
            // 
            lblPeriode.Anchor = AnchorStyles.None;
            lblPeriode.AutoSize = true;
            lblPeriode.Font = new Font("Segoe UI", 13.8F);
            lblPeriode.Location = new Point(30, 113);
            lblPeriode.Name = "lblPeriode";
            lblPeriode.Size = new Size(91, 31);
            lblPeriode.TabIndex = 1;
            lblPeriode.Text = "Periode";
            // 
            // dtpPeriode
            // 
            dtpPeriode.Anchor = AnchorStyles.None;
            dtpPeriode.Font = new Font("Segoe UI", 12F);
            dtpPeriode.Location = new Point(140, 113);
            dtpPeriode.Name = "dtpPeriode";
            dtpPeriode.Size = new Size(373, 34);
            dtpPeriode.TabIndex = 2;
            dtpPeriode.ValueChanged += DtpPeriode_ValueChanged;
            // 
            // dgvLaporan
            // 
            dgvLaporan.Anchor = AnchorStyles.None;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.BackgroundColor = SystemColors.ControlLight;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(30, 168);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 82;
            dgvLaporan.Size = new Size(1030, 521);
            dgvLaporan.TabIndex = 3;
            dgvLaporan.CellContentClick += dgvLaporan_CellContentClick;
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
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
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
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // LaporanKeuanganForm
            // 
            ClientSize = new Size(1379, 804);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(dgvLaporan);
            Controls.Add(dtpPeriode);
            Controls.Add(lblPeriode);
            Controls.Add(lblLaporanKeuangan);
            MinimumSize = new Size(1385, 814);
            Name = "LaporanKeuanganForm";
            Text = "Laporan Keuangan";
            WindowState = FormWindowState.Maximized;
            Load += LaporanKeuanganForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}
