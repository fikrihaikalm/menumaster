namespace menumaster.Views
{
    partial class Chef
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef));
            btnLihatPesanan = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnLihatPesanan
            // 
            btnLihatPesanan.Anchor = AnchorStyles.None;
            btnLihatPesanan.BackColor = Color.Lavender;
            btnLihatPesanan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLihatPesanan.ForeColor = Color.SlateBlue;
            btnLihatPesanan.Image = (Image)resources.GetObject("btnLihatPesanan.Image");
            btnLihatPesanan.ImageAlign = ContentAlignment.MiddleLeft;
            btnLihatPesanan.Location = new Point(467, 240);
            btnLihatPesanan.Margin = new Padding(6, 8, 6, 8);
            btnLihatPesanan.Name = "btnLihatPesanan";
            btnLihatPesanan.Size = new Size(272, 52);
            btnLihatPesanan.TabIndex = 0;
            btnLihatPesanan.Text = "Lihat Pesanan";
            btnLihatPesanan.UseVisualStyleBackColor = false;
            btnLihatPesanan.Click += btnLihatPesanan_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.DarkSlateBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(114, 556);
            btnBack.Margin = new Padding(6, 8, 6, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 52);
            btnBack.TabIndex = 1;
            btnBack.Text = "Logout";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Chef
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 800);
            Controls.Add(btnBack);
            Controls.Add(btnLihatPesanan);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.MediumPurple;
            Margin = new Padding(6, 8, 6, 8);
            MinimumSize = new Size(994, 736);
            Name = "Chef";
            Text = "Chef";
            WindowState = FormWindowState.Maximized;
            Load += Chef_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLihatPesanan;
        private System.Windows.Forms.Button btnBack;
    }
}