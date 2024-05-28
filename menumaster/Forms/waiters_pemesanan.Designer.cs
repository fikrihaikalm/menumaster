
namespace menumaster.Forms.Waiters
{
    partial class waiters_pemesanan
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
            name = new RichTextBox();
            LabelName = new Label();
            LableNoTelepone = new Label();
            NoTelepone = new RichTextBox();
            Tanggal = new DateTimePicker();
            LabelTanggal = new Label();
            LabelUangMuka = new Label();
            UangMuka = new RichTextBox();
            LabelMeja = new Label();
            label2 = new Label();
            Meja = new ComboBox();
            comboBox1 = new ComboBox();
            BtnSimpan = new Button();
            BtnHapus = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(231, 231, 241);
            name.BorderStyle = BorderStyle.None;
            name.DetectUrls = false;
            name.Location = new Point(257, 48);
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(570, 40);
            name.TabIndex = 0;
            name.Text = "";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelName.Location = new Point(257, 13);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(56, 23);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name";
            // 
            // LableNoTelepone
            // 
            LableNoTelepone.AutoSize = true;
            LableNoTelepone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LableNoTelepone.Location = new Point(257, 103);
            LableNoTelepone.Name = "LableNoTelepone";
            LableNoTelepone.Size = new Size(110, 23);
            LableNoTelepone.TabIndex = 3;
            LableNoTelepone.Text = "No. Telepone";
            // 
            // NoTelepone
            // 
            NoTelepone.BackColor = Color.FromArgb(231, 231, 241);
            NoTelepone.BorderStyle = BorderStyle.None;
            NoTelepone.DetectUrls = false;
            NoTelepone.Location = new Point(257, 138);
            NoTelepone.Multiline = false;
            NoTelepone.Name = "NoTelepone";
            NoTelepone.Size = new Size(570, 40);
            NoTelepone.TabIndex = 1;
            NoTelepone.Text = "";
            // 
            // Tanggal
            // 
            Tanggal.CalendarMonthBackground = SystemColors.ButtonHighlight;
            Tanggal.Location = new Point(257, 235);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(570, 27);
            Tanggal.TabIndex = 3;
            // 
            // LabelTanggal
            // 
            LabelTanggal.AutoSize = true;
            LabelTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTanggal.Location = new Point(257, 197);
            LabelTanggal.Name = "LabelTanggal";
            LabelTanggal.Size = new Size(69, 23);
            LabelTanggal.TabIndex = 5;
            LabelTanggal.Text = "Tanggal";
            // 
            // LabelUangMuka
            // 
            LabelUangMuka.AutoSize = true;
            LabelUangMuka.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUangMuka.Location = new Point(257, 282);
            LabelUangMuka.Name = "LabelUangMuka";
            LabelUangMuka.Size = new Size(98, 23);
            LabelUangMuka.TabIndex = 7;
            LabelUangMuka.Text = "Uang Muka";
            // 
            // UangMuka
            // 
            UangMuka.BackColor = Color.FromArgb(231, 231, 241);
            UangMuka.BorderStyle = BorderStyle.None;
            UangMuka.DetectUrls = false;
            UangMuka.Location = new Point(257, 317);
            UangMuka.Multiline = false;
            UangMuka.Name = "UangMuka";
            UangMuka.Size = new Size(570, 40);
            UangMuka.TabIndex = 4;
            UangMuka.Text = "";
            // 
            // LabelMeja
            // 
            LabelMeja.AutoSize = true;
            LabelMeja.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMeja.Location = new Point(257, 372);
            LabelMeja.Name = "LabelMeja";
            LabelMeja.Size = new Size(47, 23);
            LabelMeja.TabIndex = 9;
            LabelMeja.Text = "Meja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 468);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 11;
            label2.Text = "Metode Pembayaran";
            // 
            // Meja
            // 
            Meja.BackColor = Color.FromArgb(231, 231, 241);
            Meja.FormattingEnabled = true;
            Meja.Items.AddRange(new object[] { "No. 1", "No. 2", "No. 3", "No. 4", "No. 5", "No. 6", "No. 7", "No. 8", "No. 9", "No. 10" });
            Meja.Location = new Point(257, 407);
            Meja.MaxDropDownItems = 10;
            Meja.Name = "Meja";
            Meja.RightToLeft = RightToLeft.No;
            Meja.Size = new Size(570, 28);
            Meja.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(231, 231, 241);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Transfer" });
            comboBox1.Location = new Point(257, 503);
            comboBox1.MaxDropDownItems = 10;
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(570, 28);
            comboBox1.TabIndex = 12;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.FromArgb(90, 103, 186);
            BtnSimpan.ForeColor = Color.White;
            BtnSimpan.Location = new Point(954, 547);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(119, 48);
            BtnSimpan.TabIndex = 13;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.FromArgb(90, 103, 186);
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(829, 547);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(119, 48);
            BtnHapus.TabIndex = 14;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(90, 103, 186);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 547);
            button1.Name = "button1";
            button1.Size = new Size(119, 48);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // waiters_pemesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 625);
            Controls.Add(button1);
            Controls.Add(BtnHapus);
            Controls.Add(BtnSimpan);
            Controls.Add(comboBox1);
            Controls.Add(Meja);
            Controls.Add(label2);
            Controls.Add(LabelMeja);
            Controls.Add(LabelUangMuka);
            Controls.Add(UangMuka);
            Controls.Add(LabelTanggal);
            Controls.Add(Tanggal);
            Controls.Add(LableNoTelepone);
            Controls.Add(NoTelepone);
            Controls.Add(LabelName);
            Controls.Add(name);
            Name = "waiters_pemesanan";
            Text = "Waiters Pemesanan";
            WindowState = FormWindowState.Maximized;
            Load += waiters_pemesanan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox name;
        private Label LabelName;
        private Label LableNoTelepone;
        private RichTextBox NoTelepone;
        private DateTimePicker Tanggal;
        private Label LabelTanggal;
        private Label LabelUangMuka;
        private RichTextBox UangMuka;
        private Label LabelMeja;
        private Label label2;
        private ComboBox Meja;
        private ComboBox comboBox1;
        private Button BtnSimpan;
        private Button BtnHapus;
        private Button button1;
    }
}