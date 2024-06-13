namespace menumaster.Views
{
    partial class Manager_UbahKaryawan
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
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LimeGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(612, 320);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 21;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(531, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 20;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(412, 271);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(275, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(412, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(412, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(412, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label5.Location = new Point(243, 272);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 15;
            label5.Text = "Alamat";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label4.Location = new Point(243, 233);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 14;
            label4.Text = "Nomor Telepon";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label3.Location = new Point(243, 195);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 13;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.Location = new Point(243, 159);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 62);
            label1.Name = "label1";
            label1.Size = new Size(254, 22);
            label1.TabIndex = 11;
            label1.Text = "Mengubah Data Karyawan";
            // 
            // Manager_UbahKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 471);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(702, 460);
            Name = "Manager_UbahKaryawan";
            Text = "Manager Ubah Karyawan";
            WindowState = FormWindowState.Maximized;
            Load += Manager_UbahKaryawan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}