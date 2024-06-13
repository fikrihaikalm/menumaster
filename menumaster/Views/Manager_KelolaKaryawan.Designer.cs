namespace menumaster.Views
{
    partial class Manager_KelolaKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_KelolaKaryawan));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id_karyawan = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            telp = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            foto = new DataGridViewTextBoxColumn();
            aktif = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(313, 126);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(827, 116);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(131, 39);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DarkSlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(20, 741);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(135, 54);
            button2.TabIndex = 2;
            button2.Text = "Back";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 3;
            label1.Text = "Kelola Karyawan";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_karyawan, nama, telp, alamat, foto, aktif });
            dataGridView1.Location = new Point(304, 190);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(654, 489);
            dataGridView1.TabIndex = 4;
            // 
            // id_karyawan
            // 
            id_karyawan.DataPropertyName = "id_karyawan";
            id_karyawan.HeaderText = "ID";
            id_karyawan.MinimumWidth = 8;
            id_karyawan.Name = "id_karyawan";
            id_karyawan.Width = 150;
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.Width = 150;
            // 
            // telp
            // 
            telp.DataPropertyName = "telp";
            telp.HeaderText = "Telp";
            telp.MinimumWidth = 8;
            telp.Name = "telp";
            telp.Width = 150;
            // 
            // alamat
            // 
            alamat.DataPropertyName = "alamat";
            alamat.HeaderText = "Alamat";
            alamat.MinimumWidth = 8;
            alamat.Name = "alamat";
            alamat.Width = 150;
            // 
            // foto
            // 
            foto.DataPropertyName = "foto";
            foto.HeaderText = "Foto";
            foto.MinimumWidth = 8;
            foto.Name = "foto";
            foto.Width = 150;
            // 
            // aktif
            // 
            aktif.DataPropertyName = "aktif";
            aktif.HeaderText = "Aktif";
            aktif.MinimumWidth = 8;
            aktif.Name = "aktif";
            aktif.Width = 150;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(1029, 190);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(131, 50);
            button3.TabIndex = 5;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.DarkSeaGreen;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(1029, 248);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(131, 50);
            button4.TabIndex = 6;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.MistyRose;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 13.8F);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(1029, 306);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(131, 50);
            button5.TabIndex = 7;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Manager_KelolaKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 810);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1385, 814);
            Name = "Manager_KelolaKaryawan";
            Text = "Manager Kelola Karyawan";
            WindowState = FormWindowState.Maximized;
            Load += Manager_KelolaKaryawan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn id_karyawan;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn telp;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn foto;
        private DataGridViewTextBoxColumn aktif;
    }
}