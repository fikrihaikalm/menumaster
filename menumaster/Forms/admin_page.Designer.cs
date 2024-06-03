namespace menumaster
{
    partial class admin_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_page));
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(540, 442);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(309, 104);
            button3.TabIndex = 2;
            button3.Text = "Kelola Menu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(540, 285);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(309, 107);
            button1.TabIndex = 0;
            button1.Text = "Pengeluaran";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(540, 129);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(309, 104);
            button2.TabIndex = 1;
            button2.Text = "Pendapatan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 3;
            label1.Text = "ADMIN";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(578, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 40);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Payment;
            pictureBox2.Location = new Point(583, 325);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 32);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Manage;
            pictureBox3.Location = new Point(579, 477);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 37);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // admin_page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 805);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(4);
            MinimumSize = new Size(994, 736);
            Name = "admin_page";
            Text = "admin_page";
            WindowState = FormWindowState.Maximized;
            Load += admin_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}