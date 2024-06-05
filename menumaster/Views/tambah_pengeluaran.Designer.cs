namespace menumaster
{
    partial class tambah_pengeluaran
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(448, 410);
            button4.Name = "button4";
            button4.Size = new Size(373, 51);
            button4.TabIndex = 24;
            button4.Text = "Tambah Jenis Pengeluaran";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(841, 297);
            button3.Name = "button3";
            button3.Size = new Size(122, 63);
            button3.TabIndex = 23;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(841, 220);
            button2.Name = "button2";
            button2.Size = new Size(122, 61);
            button2.TabIndex = 22;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bahan Baku", "Air", "Listrik", "Pajak Bangunan" });
            comboBox1.Location = new Point(382, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(442, 46);
            comboBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(379, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 45);
            textBox2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(382, 272);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(442, 45);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += this.dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(102, 322);
            label4.Name = "label4";
            label4.Size = new Size(262, 38);
            label4.TabIndex = 18;
            label4.Text = "Jumlah                   :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(102, 272);
            label3.Name = "label3";
            label3.Size = new Size(262, 38);
            label3.TabIndex = 17;
            label3.Text = "Tanggal                  :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(102, 217);
            label2.Name = "label2";
            label2.Size = new Size(261, 38);
            label2.TabIndex = 16;
            label2.Text = "Jenis Pengeluaran  :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 35);
            label1.TabIndex = 25;
            label1.Text = "Tambah Pengeluaran";
            // 
            // tambah_pengeluaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 625);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "tambah_pengeluaran";
            Text = "tambah_pengeluaran";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}