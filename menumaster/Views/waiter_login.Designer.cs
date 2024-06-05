namespace menumaster
{
    partial class Login_kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_kasir));
            button1 = new Button();
            passwordtxt = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(315, 670);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(166, 67);
            button1.TabIndex = 13;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Anchor = AnchorStyles.None;
            passwordtxt.Location = new Point(96, 562);
            passwordtxt.Margin = new Padding(5, 5, 5, 5);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(383, 39);
            passwordtxt.TabIndex = 12;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 496);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 45);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(96, 390);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 39);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 341);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 45);
            label3.TabIndex = 9;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 237);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(378, 40);
            label2.TabIndex = 8;
            label2.Text = "please login to your account";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 37.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 54);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(811, 135);
            label1.TabIndex = 7;
            label1.Text = "Selamat Datang";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(96, 670);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(166, 67);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(902, 181);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(728, 557);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Login_kasir
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1773, 1024);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordtxt);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(1284, 917);
            Name = "Login_kasir";
            Text = "Login kasir";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox passwordtxt;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}