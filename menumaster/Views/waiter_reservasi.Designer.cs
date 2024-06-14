
namespace menumaster.Forms.Waiters
{
    partial class waiter_reservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waiter_reservasi));
            textBoxNama = new RichTextBox();
            LabelName = new Label();
            LableNoTelepone = new Label();
            textBoxTelp = new RichTextBox();
            dateTimePickerTanggal = new DateTimePicker();
            LabelTanggal = new Label();
            LabelMeja = new Label();
            label2 = new Label();
            comboBoxMeja = new ComboBox();
            comboBoxMetodePembayaran = new ComboBox();
            BtnSimpan = new Button();
            btnBack = new Button();
            numericUpDownDurasi = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            numericUpDownWaktu = new NumericUpDown();
            numericUpDownJumlahOrang = new NumericUpDown();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWaktu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlahOrang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNama
            // 
            textBoxNama.Anchor = AnchorStyles.None;
            textBoxNama.BackColor = Color.FromArgb(231, 231, 241);
            textBoxNama.BorderStyle = BorderStyle.None;
            textBoxNama.DetectUrls = false;
            textBoxNama.Font = new Font("Segoe UI", 13.8F);
            textBoxNama.Location = new Point(398, 138);
            textBoxNama.Multiline = false;
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(570, 40);
            textBoxNama.TabIndex = 0;
            textBoxNama.Text = "";
            // 
            // LabelName
            // 
            LabelName.Anchor = AnchorStyles.None;
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 13.8F);
            LabelName.Location = new Point(398, 104);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(75, 31);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name";
            // 
            // LableNoTelepone
            // 
            LableNoTelepone.Anchor = AnchorStyles.None;
            LableNoTelepone.AutoSize = true;
            LableNoTelepone.Font = new Font("Segoe UI", 13.8F);
            LableNoTelepone.Location = new Point(398, 194);
            LableNoTelepone.Name = "LableNoTelepone";
            LableNoTelepone.Size = new Size(147, 31);
            LableNoTelepone.TabIndex = 3;
            LableNoTelepone.Text = "No. Telepone";
            // 
            // textBoxTelp
            // 
            textBoxTelp.Anchor = AnchorStyles.None;
            textBoxTelp.BackColor = Color.FromArgb(231, 231, 241);
            textBoxTelp.BorderStyle = BorderStyle.None;
            textBoxTelp.DetectUrls = false;
            textBoxTelp.Font = new Font("Segoe UI", 13.8F);
            textBoxTelp.Location = new Point(398, 229);
            textBoxTelp.Multiline = false;
            textBoxTelp.Name = "textBoxTelp";
            textBoxTelp.Size = new Size(570, 40);
            textBoxTelp.TabIndex = 1;
            textBoxTelp.Text = "";
            // 
            // dateTimePickerTanggal
            // 
            dateTimePickerTanggal.Anchor = AnchorStyles.None;
            dateTimePickerTanggal.CalendarMonthBackground = SystemColors.ButtonHighlight;
            dateTimePickerTanggal.Font = new Font("Segoe UI", 12F);
            dateTimePickerTanggal.Location = new Point(398, 326);
            dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            dateTimePickerTanggal.Size = new Size(345, 34);
            dateTimePickerTanggal.TabIndex = 3;
            // 
            // LabelTanggal
            // 
            LabelTanggal.Anchor = AnchorStyles.None;
            LabelTanggal.AutoSize = true;
            LabelTanggal.Font = new Font("Segoe UI", 13.8F);
            LabelTanggal.Location = new Point(398, 288);
            LabelTanggal.Name = "LabelTanggal";
            LabelTanggal.Size = new Size(94, 31);
            LabelTanggal.TabIndex = 5;
            LabelTanggal.Text = "Tanggal";
            // 
            // LabelMeja
            // 
            LabelMeja.Anchor = AnchorStyles.None;
            LabelMeja.AutoSize = true;
            LabelMeja.Font = new Font("Segoe UI", 13.8F);
            LabelMeja.Location = new Point(398, 460);
            LabelMeja.Name = "LabelMeja";
            LabelMeja.Size = new Size(65, 31);
            LabelMeja.TabIndex = 9;
            LabelMeja.Text = "Meja";
            LabelMeja.Click += LabelMeja_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(398, 547);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 11;
            label2.Text = "Metode Pembayaran";
            // 
            // comboBoxMeja
            // 
            comboBoxMeja.Anchor = AnchorStyles.None;
            comboBoxMeja.BackColor = Color.FromArgb(231, 231, 241);
            comboBoxMeja.FormattingEnabled = true;
            comboBoxMeja.Location = new Point(398, 503);
            comboBoxMeja.MaxDropDownItems = 10;
            comboBoxMeja.Name = "comboBoxMeja";
            comboBoxMeja.RightToLeft = RightToLeft.No;
            comboBoxMeja.Size = new Size(570, 28);
            comboBoxMeja.TabIndex = 5;
            // 
            // comboBoxMetodePembayaran
            // 
            comboBoxMetodePembayaran.Anchor = AnchorStyles.None;
            comboBoxMetodePembayaran.BackColor = Color.FromArgb(231, 231, 241);
            comboBoxMetodePembayaran.FormattingEnabled = true;
            comboBoxMetodePembayaran.Location = new Point(398, 582);
            comboBoxMetodePembayaran.MaxDropDownItems = 10;
            comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            comboBoxMetodePembayaran.RightToLeft = RightToLeft.No;
            comboBoxMetodePembayaran.Size = new Size(570, 28);
            comboBoxMetodePembayaran.TabIndex = 12;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Anchor = AnchorStyles.None;
            BtnSimpan.BackColor = SystemColors.GradientActiveCaption;
            BtnSimpan.Font = new Font("Segoe UI", 13.8F);
            BtnSimpan.ForeColor = SystemColors.ControlText;
            BtnSimpan.Location = new Point(837, 638);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(131, 50);
            BtnSimpan.TabIndex = 13;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.DarkSlateBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(20, 719);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 54);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // numericUpDownDurasi
            // 
            numericUpDownDurasi.Anchor = AnchorStyles.None;
            numericUpDownDurasi.Location = new Point(907, 333);
            numericUpDownDurasi.Margin = new Padding(2, 2, 2, 2);
            numericUpDownDurasi.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownDurasi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDurasi.Name = "numericUpDownDurasi";
            numericUpDownDurasi.Size = new Size(50, 27);
            numericUpDownDurasi.TabIndex = 17;
            numericUpDownDurasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(732, 299);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(884, 292);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 19;
            // 
            // numericUpDownWaktu
            // 
            numericUpDownWaktu.Anchor = AnchorStyles.None;
            numericUpDownWaktu.Location = new Point(771, 333);
            numericUpDownWaktu.Margin = new Padding(2, 2, 2, 2);
            numericUpDownWaktu.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownWaktu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWaktu.Name = "numericUpDownWaktu";
            numericUpDownWaktu.Size = new Size(92, 27);
            numericUpDownWaktu.TabIndex = 20;
            numericUpDownWaktu.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownJumlahOrang
            // 
            numericUpDownJumlahOrang.Anchor = AnchorStyles.None;
            numericUpDownJumlahOrang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownJumlahOrang.Location = new Point(398, 419);
            numericUpDownJumlahOrang.Margin = new Padding(1, 1, 1, 1);
            numericUpDownJumlahOrang.Name = "numericUpDownJumlahOrang";
            numericUpDownJumlahOrang.Size = new Size(147, 30);
            numericUpDownJumlahOrang.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(398, 385);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(771, 288);
            label6.Name = "label6";
            label6.Size = new Size(78, 31);
            label6.TabIndex = 24;
            label6.Text = "Waktu";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(398, 376);
            label7.Name = "label7";
            label7.Size = new Size(156, 31);
            label7.TabIndex = 25;
            label7.Text = "Jumlah Orang";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(889, 288);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 26;
            label5.Text = "Durasi";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackgroundImage = Properties.Resources.ep_back;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 739);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // waiter_reservasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 807);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(numericUpDownJumlahOrang);
            Controls.Add(numericUpDownWaktu);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDownDurasi);
            Controls.Add(btnBack);
            Controls.Add(BtnSimpan);
            Controls.Add(comboBoxMetodePembayaran);
            Controls.Add(comboBoxMeja);
            Controls.Add(label2);
            Controls.Add(LabelMeja);
            Controls.Add(LabelTanggal);
            Controls.Add(dateTimePickerTanggal);
            Controls.Add(LableNoTelepone);
            Controls.Add(textBoxTelp);
            Controls.Add(LabelName);
            Controls.Add(textBoxNama);
            MinimumSize = new Size(1385, 814);
            Name = "waiter_reservasi";
            Text = "Waiters Reservasi";
            WindowState = FormWindowState.Maximized;
            Load += waiters_pemesanan_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWaktu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlahOrang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBoxNama;
        private Label LabelName;
        private Label LableNoTelepone;
        private RichTextBox textBoxTelp;
        private DateTimePicker dateTimePickerTanggal;
        private Label LabelTanggal;
        private Label LabelMeja;
        private Label label2;
        private ComboBox comboBoxMeja;
        private ComboBox comboBoxMetodePembayaran;
        private Button BtnSimpan;
        private Button btnBack;
        private NumericUpDown numericUpDownDurasi;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDownWaktu;
        private NumericUpDown numericUpDownJumlahOrang;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private PictureBox pictureBox1;
    }
}