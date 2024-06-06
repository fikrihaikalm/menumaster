
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWaktu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlahOrang).BeginInit();
            SuspendLayout();
            // 
            // textBoxNama
            // 
            textBoxNama.Anchor = AnchorStyles.None;
            textBoxNama.BackColor = Color.FromArgb(231, 231, 241);
            textBoxNama.BorderStyle = BorderStyle.None;
            textBoxNama.DetectUrls = false;
            textBoxNama.Location = new Point(418, 77);
            textBoxNama.Margin = new Padding(5);
            textBoxNama.Multiline = false;
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(926, 64);
            textBoxNama.TabIndex = 0;
            textBoxNama.Text = "";
            // 
            // LabelName
            // 
            LabelName.Anchor = AnchorStyles.None;
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelName.Location = new Point(418, 21);
            LabelName.Margin = new Padding(5, 0, 5, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(91, 38);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name";
            // 
            // LableNoTelepone
            // 
            LableNoTelepone.Anchor = AnchorStyles.None;
            LableNoTelepone.AutoSize = true;
            LableNoTelepone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LableNoTelepone.Location = new Point(418, 165);
            LableNoTelepone.Margin = new Padding(5, 0, 5, 0);
            LableNoTelepone.Name = "LableNoTelepone";
            LableNoTelepone.Size = new Size(180, 38);
            LableNoTelepone.TabIndex = 3;
            LableNoTelepone.Text = "No. Telepone";
            // 
            // textBoxTelp
            // 
            textBoxTelp.Anchor = AnchorStyles.None;
            textBoxTelp.BackColor = Color.FromArgb(231, 231, 241);
            textBoxTelp.BorderStyle = BorderStyle.None;
            textBoxTelp.DetectUrls = false;
            textBoxTelp.Location = new Point(418, 221);
            textBoxTelp.Margin = new Padding(5);
            textBoxTelp.Multiline = false;
            textBoxTelp.Name = "textBoxTelp";
            textBoxTelp.Size = new Size(926, 64);
            textBoxTelp.TabIndex = 1;
            textBoxTelp.Text = "";
            // 
            // dateTimePickerTanggal
            // 
            dateTimePickerTanggal.Anchor = AnchorStyles.None;
            dateTimePickerTanggal.CalendarMonthBackground = SystemColors.ButtonHighlight;
            dateTimePickerTanggal.Location = new Point(418, 376);
            dateTimePickerTanggal.Margin = new Padding(5);
            dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            dateTimePickerTanggal.Size = new Size(438, 39);
            dateTimePickerTanggal.TabIndex = 3;
            // 
            // LabelTanggal
            // 
            LabelTanggal.Anchor = AnchorStyles.None;
            LabelTanggal.AutoSize = true;
            LabelTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTanggal.Location = new Point(418, 315);
            LabelTanggal.Margin = new Padding(5, 0, 5, 0);
            LabelTanggal.Name = "LabelTanggal";
            LabelTanggal.Size = new Size(112, 38);
            LabelTanggal.TabIndex = 5;
            LabelTanggal.Text = "Tanggal";
            // 
            // LabelMeja
            // 
            LabelMeja.Anchor = AnchorStyles.None;
            LabelMeja.AutoSize = true;
            LabelMeja.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMeja.Location = new Point(431, 614);
            LabelMeja.Margin = new Padding(5, 0, 5, 0);
            LabelMeja.Name = "LabelMeja";
            LabelMeja.Size = new Size(78, 38);
            LabelMeja.TabIndex = 9;
            LabelMeja.Text = "Meja";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 749);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 38);
            label2.TabIndex = 11;
            label2.Text = "Metode Pembayaran";
            // 
            // comboBoxMeja
            // 
            comboBoxMeja.Anchor = AnchorStyles.None;
            comboBoxMeja.BackColor = Color.FromArgb(231, 231, 241);
            comboBoxMeja.FormattingEnabled = true;
            comboBoxMeja.Location = new Point(418, 678);
            comboBoxMeja.Margin = new Padding(5);
            comboBoxMeja.MaxDropDownItems = 10;
            comboBoxMeja.Name = "comboBoxMeja";
            comboBoxMeja.RightToLeft = RightToLeft.No;
            comboBoxMeja.Size = new Size(924, 40);
            comboBoxMeja.TabIndex = 5;
            // 
            // comboBoxMetodePembayaran
            // 
            comboBoxMetodePembayaran.Anchor = AnchorStyles.None;
            comboBoxMetodePembayaran.BackColor = Color.FromArgb(231, 231, 241);
            comboBoxMetodePembayaran.FormattingEnabled = true;
            comboBoxMetodePembayaran.Location = new Point(418, 805);
            comboBoxMetodePembayaran.Margin = new Padding(5);
            comboBoxMetodePembayaran.MaxDropDownItems = 10;
            comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            comboBoxMetodePembayaran.RightToLeft = RightToLeft.No;
            comboBoxMetodePembayaran.Size = new Size(924, 40);
            comboBoxMetodePembayaran.TabIndex = 12;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Anchor = AnchorStyles.None;
            BtnSimpan.BackColor = Color.FromArgb(90, 103, 186);
            BtnSimpan.ForeColor = Color.White;
            BtnSimpan.Location = new Point(1535, 875);
            BtnSimpan.Margin = new Padding(5);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(193, 77);
            BtnSimpan.TabIndex = 13;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(90, 103, 186);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(20, 875);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(193, 77);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // numericUpDownDurasi
            // 
            numericUpDownDurasi.Anchor = AnchorStyles.None;
            numericUpDownDurasi.Location = new Point(1207, 376);
            numericUpDownDurasi.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownDurasi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDurasi.Name = "numericUpDownDurasi";
            numericUpDownDurasi.Size = new Size(82, 39);
            numericUpDownDurasi.TabIndex = 17;
            numericUpDownDurasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(883, 321);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(1207, 321);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 19;
            // 
            // numericUpDownWaktu
            // 
            numericUpDownWaktu.Anchor = AnchorStyles.None;
            numericUpDownWaktu.Location = new Point(883, 376);
            numericUpDownWaktu.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownWaktu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWaktu.Name = "numericUpDownWaktu";
            numericUpDownWaktu.Size = new Size(240, 39);
            numericUpDownWaktu.TabIndex = 20;
            numericUpDownWaktu.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownJumlahOrang
            // 
            numericUpDownJumlahOrang.Anchor = AnchorStyles.None;
            numericUpDownJumlahOrang.Location = new Point(418, 528);
            numericUpDownJumlahOrang.Name = "numericUpDownJumlahOrang";
            numericUpDownJumlahOrang.Size = new Size(240, 39);
            numericUpDownJumlahOrang.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(418, 471);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(883, 315);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 38);
            label6.TabIndex = 24;
            label6.Text = "Waktu";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(418, 456);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(189, 38);
            label7.TabIndex = 25;
            label7.Text = "Jumlah Orang";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1207, 315);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 38);
            label5.TabIndex = 26;
            label5.Text = "Durasi";
            // 
            // waiter_reservasi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1763, 1000);
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
            Margin = new Padding(5);
            Name = "waiter_reservasi";
            Text = "Waiters Reservasi";
            WindowState = FormWindowState.Maximized;
            Load += waiters_pemesanan_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWaktu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlahOrang).EndInit();
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
    }
}