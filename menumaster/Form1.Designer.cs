namespace menumaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 10.8F);
            button1.Location = new Point(85, 348);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(225, 43);
            button1.TabIndex = 0;
            button1.Text = "Login sebagai admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 21);
            label1.Name = "label1";
            label1.Size = new Size(642, 106);
            label1.TabIndex = 2;
            label1.Text = "Selamat Datang";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 10.8F);
            button2.Location = new Point(378, 348);
            button2.Name = "button2";
            button2.Size = new Size(225, 43);
            button2.TabIndex = 1;
            button2.Text = "Login sebagai manajer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 10.8F);
            button3.Location = new Point(664, 348);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(225, 43);
            button3.TabIndex = 3;
            button3.Text = "Login sebagai kasir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(483, 127);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 4;
            label2.Text = "silahkan login";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(228, 303);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 5;
            label3.Text = "Admin";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(504, 303);
            label4.Name = "label4";
            label4.Size = new Size(99, 31);
            label4.TabIndex = 6;
            label4.Text = "Manajer";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(824, 303);
            label5.Name = "label5";
            label5.Size = new Size(65, 31);
            label5.TabIndex = 7;
            label5.Text = "Kasir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1094, 628);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "welcome page";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
