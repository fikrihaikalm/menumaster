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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
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
            button3.Size = new Size(309, 129);
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
            button1.Size = new Size(309, 132);
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
            button2.Size = new Size(309, 129);
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
            // admin_page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 805);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(4);
            MinimumSize = new Size(994, 736);
            Name = "admin_page";
            Text = "admin_page";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}