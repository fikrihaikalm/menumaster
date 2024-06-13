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
            lblLaporanKeuangan = new Label();
            lblPeriode = new Label();
            dtpPeriode = new DateTimePicker();
            dgvLaporan = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            SuspendLayout();
            // 
            // lblLaporanKeuangan
            // 
            lblLaporanKeuangan.Anchor = AnchorStyles.None;
            lblLaporanKeuangan.AutoSize = true;
            lblLaporanKeuangan.Font = new Font("Microsoft Sans Serif", 16F);
            lblLaporanKeuangan.Location = new Point(30, 9);
            lblLaporanKeuangan.Name = "lblLaporanKeuangan";
            lblLaporanKeuangan.Size = new Size(388, 51);
            lblLaporanKeuangan.TabIndex = 0;
            lblLaporanKeuangan.Text = "Laporan Keuangan";
            // 
            // lblPeriode
            // 
            lblPeriode.Anchor = AnchorStyles.None;
            lblPeriode.AutoSize = true;
            lblPeriode.Location = new Point(30, 80);
            lblPeriode.Name = "lblPeriode";
            lblPeriode.Size = new Size(99, 32);
            lblPeriode.TabIndex = 1;
            lblPeriode.Text = "Periode:";
            // 
            // dtpPeriode
            // 
            dtpPeriode.Anchor = AnchorStyles.None;
            dtpPeriode.Location = new Point(126, 73);
            dtpPeriode.Name = "dtpPeriode";
            dtpPeriode.Size = new Size(424, 39);
            dtpPeriode.TabIndex = 2;
            dtpPeriode.ValueChanged += DtpPeriode_ValueChanged;
            // 
            // dgvLaporan
            // 
            dgvLaporan.Anchor = AnchorStyles.None;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(30, 120);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.RowHeadersWidth = 82;
            dgvLaporan.Size = new Size(1030, 570);
            dgvLaporan.TabIndex = 3;
            dgvLaporan.CellContentClick += dgvLaporan_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Location = new Point(30, 696);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 49);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // LaporanKeuanganForm
            // 
            ClientSize = new Size(1379, 773);
            Controls.Add(btnBack);
            Controls.Add(dgvLaporan);
            Controls.Add(dtpPeriode);
            Controls.Add(lblPeriode);
            Controls.Add(lblLaporanKeuangan);
            MinimumSize = new Size(994, 736);
            Name = "LaporanKeuanganForm";
            Text = "Laporan Keuangan";
            WindowState = FormWindowState.Maximized;
            Load += LaporanKeuanganForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
