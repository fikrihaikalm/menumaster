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
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            btnlaporankeuangan.Location = new Point(430, 238);
            btnlaporankeuangan.Margin = new Padding(5);
            btnlaporankeuangan.Name = "btnlaporankeuangan";
            btnlaporankeuangan.Size = new Size(489, 102);
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
            btnkelolakaryawan.Location = new Point(430, 376);
            btnkelolakaryawan.Margin = new Padding(5);
            btnkelolakaryawan.Name = "btnkelolakaryawan";
            btnkelolakaryawan.Size = new Size(489, 102);
            btnkelolakaryawan.TabIndex = 1;
            btnkelolakaryawan.Text = "Kelola Karyawan";
            btnkelolakaryawan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnkelolakaryawan.UseVisualStyleBackColor = false;
            btnkelolakaryawan.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(43, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 34);
            label1.TabIndex = 2;
            label1.Text = "Manager";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.MidnightBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(43, 705);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(135, 52);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 33);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(477, 407);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Manager_Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 785);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnkelolakaryawan);
            Controls.Add(btnlaporankeuangan);
            Controls.Add(button3);
            Controls.Add(label1);
            Margin = new Padding(5);
            MinimumSize = new Size(990, 716);
            Name = "Manager_Homepage";
            Text = "Manager Homepage";
            WindowState = FormWindowState.Maximized;
            Load += Manager_Homepage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlaporankeuangan;
        private Button btnkelolakaryawan;
        private Label label1;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}