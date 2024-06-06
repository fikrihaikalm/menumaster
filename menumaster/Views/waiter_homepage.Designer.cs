namespace menumaster.Views
{
    partial class waiter_homepage
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
            btnPesan = new Button();
            btnReservasi = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnPesan
            // 
            btnPesan.Anchor = AnchorStyles.None;
            btnPesan.BackColor = SystemColors.MenuHighlight;
            btnPesan.Font = new Font("Sylfaen", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesan.Location = new Point(741, 177);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(348, 73);
            btnPesan.TabIndex = 0;
            btnPesan.Text = "BUAT PESANAN";
            btnPesan.UseVisualStyleBackColor = false;
            btnPesan.Click += btnPesan_Click;
            // 
            // btnReservasi
            // 
            btnReservasi.Anchor = AnchorStyles.None;
            btnReservasi.BackColor = SystemColors.MenuHighlight;
            btnReservasi.Font = new Font("Sylfaen", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservasi.Location = new Point(741, 365);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(348, 73);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "RESERVASI";
            btnReservasi.UseVisualStyleBackColor = false;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.Location = new Point(76, 693);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // waiter_homepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1873, 811);
            Controls.Add(btnLogout);
            Controls.Add(btnReservasi);
            Controls.Add(btnPesan);
            Name = "waiter_homepage";
            Text = "waiter_homepage";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPesan;
        private Button btnReservasi;
        private Button btnLogout;
    }
}