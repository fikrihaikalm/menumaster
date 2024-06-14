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
            btnlaporankeuangan = new Button();
            btnkelolakaryawan = new Button();
            label1 = new Label();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnlaporankeuangan
            // 
            btnlaporankeuangan.Anchor = AnchorStyles.None;
            btnlaporankeuangan.BackColor = SystemColors.GradientInactiveCaption;
            btnlaporankeuangan.FlatAppearance.BorderSize = 0;
            btnlaporankeuangan.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnlaporankeuangan.FlatStyle = FlatStyle.Flat;
            btnlaporankeuangan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlaporankeuangan.ForeColor = Color.Black;
            btnlaporankeuangan.Location = new Point(473, 302);
            btnlaporankeuangan.Margin = new Padding(2);
            btnlaporankeuangan.Name = "btnlaporankeuangan";
            btnlaporankeuangan.Size = new Size(465, 83);
            btnlaporankeuangan.TabIndex = 0;
            btnlaporankeuangan.Text = "Laporan Keuangan";
            btnlaporankeuangan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlaporankeuangan.UseVisualStyleBackColor = false;
            btnlaporankeuangan.Click += btnlaporankeuangan_Click;
            // 
            // btnkelolakaryawan
            // 
            btnkelolakaryawan.Anchor = AnchorStyles.None;
            btnkelolakaryawan.BackColor = SystemColors.GradientInactiveCaption;
            btnkelolakaryawan.FlatAppearance.BorderSize = 0;
            btnkelolakaryawan.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnkelolakaryawan.FlatStyle = FlatStyle.Flat;
            btnkelolakaryawan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnkelolakaryawan.ForeColor = Color.Black;
            btnkelolakaryawan.Location = new Point(473, 409);
            btnkelolakaryawan.Margin = new Padding(2);
            btnkelolakaryawan.Name = "btnkelolakaryawan";
            btnkelolakaryawan.Size = new Size(465, 83);
            btnkelolakaryawan.TabIndex = 1;
            btnkelolakaryawan.Text = "Kelola Karyawan";
            btnkelolakaryawan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnkelolakaryawan.UseVisualStyleBackColor = false;
            btnkelolakaryawan.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(20, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 41);
            label1.TabIndex = 2;
            label1.Text = "Manager";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.DarkSlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(20, 703);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(135, 54);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImage = Properties.Resources.Payment;
            pictureBox4.Location = new Point(507, 334);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 26);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImage = Properties.Resources.Manage;
            pictureBox3.Location = new Point(508, 426);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 30);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Manager_Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 767);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(btnkelolakaryawan);
            Controls.Add(btnlaporankeuangan);
            Controls.Add(button3);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(1385, 814);
            Name = "Manager_Homepage";
            Text = "Manager Homepage";
            WindowState = FormWindowState.Maximized;
            Load += Manager_Homepage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlaporankeuangan;
        private Button btnkelolakaryawan;
        private Label label1;
        private Button button3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}