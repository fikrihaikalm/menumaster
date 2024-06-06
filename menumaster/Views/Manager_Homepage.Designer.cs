namespace menumaster.Forms
{
    partial class Manager_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Homepage));
            btnlaporankeuangan = new Button();
            btnkelolakaryawan = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnlaporankeuangan
            // 
            btnlaporankeuangan.Anchor = AnchorStyles.None;
            btnlaporankeuangan.BackColor = Color.Lavender;
            btnlaporankeuangan.FlatAppearance.BorderSize = 0;
            btnlaporankeuangan.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnlaporankeuangan.FlatStyle = FlatStyle.Flat;
            btnlaporankeuangan.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlaporankeuangan.ForeColor = Color.RoyalBlue;
            btnlaporankeuangan.Image = (Image)resources.GetObject("btnlaporankeuangan.Image");
            btnlaporankeuangan.Location = new Point(156, 143);
            btnlaporankeuangan.Margin = new Padding(6, 6, 6, 6);
            btnlaporankeuangan.Name = "btnlaporankeuangan";
            btnlaporankeuangan.Size = new Size(487, 100);
            btnlaporankeuangan.TabIndex = 0;
            btnlaporankeuangan.Text = "Laporan Keuangan";
            btnlaporankeuangan.TextAlign = ContentAlignment.MiddleRight;
            btnlaporankeuangan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlaporankeuangan.UseVisualStyleBackColor = false;
            btnlaporankeuangan.Click += btnlaporankeuangan_Click;
            // 
            // btnkelolakaryawan
            // 
            btnkelolakaryawan.Anchor = AnchorStyles.None;
            btnkelolakaryawan.BackColor = Color.Lavender;
            btnkelolakaryawan.FlatAppearance.BorderSize = 0;
            btnkelolakaryawan.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnkelolakaryawan.FlatStyle = FlatStyle.Flat;
            btnkelolakaryawan.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkelolakaryawan.ForeColor = Color.RoyalBlue;
            btnkelolakaryawan.Image = (Image)resources.GetObject("btnkelolakaryawan.Image");
            btnkelolakaryawan.Location = new Point(156, 282);
            btnkelolakaryawan.Margin = new Padding(6, 6, 6, 6);
            btnkelolakaryawan.Name = "btnkelolakaryawan";
            btnkelolakaryawan.Size = new Size(487, 100);
            btnkelolakaryawan.TabIndex = 1;
            btnkelolakaryawan.Text = "Kelola Karyawan";
            btnkelolakaryawan.TextAlign = ContentAlignment.MiddleRight;
            btnkelolakaryawan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnkelolakaryawan.UseVisualStyleBackColor = false;
            btnkelolakaryawan.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(56, 55);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 45);
            label1.TabIndex = 2;
            label1.Text = "Manager";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnlaporankeuangan);
            panel1.Controls.Add(btnkelolakaryawan);
            panel1.Location = new Point(492, 194);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 544);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.RoyalBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(78, 887);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(176, 66);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Manager_Homepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1005);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(1281, 901);
            Name = "Manager_Homepage";
            Text = "Manager Homepage";
            WindowState = FormWindowState.Maximized;
            Load += Manager_Homepage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlaporankeuangan;
        private Button btnkelolakaryawan;
        private Label label1;
        private Panel panel1;
        private Button button3;
    }
}