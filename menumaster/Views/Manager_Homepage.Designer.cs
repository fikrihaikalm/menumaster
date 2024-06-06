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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Lavender;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.RoyalBlue;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(84, 67);
            button1.Name = "button1";
            button1.Size = new Size(262, 47);
            button1.TabIndex = 0;
            button1.Text = "Laporan Keuangan";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Lavender;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.RoyalBlue;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(84, 132);
            button2.Name = "button2";
            button2.Size = new Size(262, 47);
            button2.TabIndex = 1;
            button2.Text = "Kelola Karyawan";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 2;
            label1.Text = "Manager";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(265, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 255);
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
            button3.Location = new Point(42, 416);
            button3.Name = "button3";
            button3.Size = new Size(95, 31);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Manager_Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 471);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label1);
            MinimumSize = new Size(702, 460);
            Name = "Manager_Homepage";
            Text = "Manager Homepage";
            WindowState = FormWindowState.Maximized;
            Load += Manager_Homepage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Button button3;
    }
}