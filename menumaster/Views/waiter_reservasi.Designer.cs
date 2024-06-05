
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
            btnBack = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(231, 231, 241);
            name.BorderStyle = BorderStyle.None;
            name.DetectUrls = false;
            name.Location = new Point(418, 77);
            name.Margin = new Padding(5);
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(926, 64);
            name.TabIndex = 0;
            name.Text = "";
            // 
            // LabelName
            // 
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
            LableNoTelepone.AutoSize = true;
            LableNoTelepone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LableNoTelepone.Location = new Point(418, 165);
            LableNoTelepone.Margin = new Padding(5, 0, 5, 0);
            LableNoTelepone.Name = "LableNoTelepone";
            LableNoTelepone.Size = new Size(180, 38);
            LableNoTelepone.TabIndex = 3;
            LableNoTelepone.Text = "No. Telepone";
            // 
            // NoTelepone
            // 
            NoTelepone.BackColor = Color.FromArgb(231, 231, 241);
            NoTelepone.BorderStyle = BorderStyle.None;
            NoTelepone.DetectUrls = false;
            NoTelepone.Location = new Point(418, 221);
            NoTelepone.Margin = new Padding(5);
            NoTelepone.Multiline = false;
            NoTelepone.Name = "NoTelepone";
            NoTelepone.Size = new Size(926, 64);
            NoTelepone.TabIndex = 1;
            NoTelepone.Text = "";
            // 
            // Tanggal
            // 
            Tanggal.CalendarMonthBackground = SystemColors.ButtonHighlight;
            Tanggal.Location = new Point(418, 376);
            Tanggal.Margin = new Padding(5);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(924, 39);
            Tanggal.TabIndex = 3;
            // 
            // LabelTanggal
            // 
            LabelTanggal.AutoSize = true;
            LabelTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTanggal.Location = new Point(418, 315);
            LabelTanggal.Margin = new Padding(5, 0, 5, 0);
            LabelTanggal.Name = "LabelTanggal";
            LabelTanggal.Size = new Size(112, 38);
            LabelTanggal.TabIndex = 5;
            LabelTanggal.Text = "Tanggal";
            // 
            // LabelUangMuka
            // 
            LabelUangMuka.AutoSize = true;
            LabelUangMuka.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUangMuka.Location = new Point(418, 451);
            LabelUangMuka.Margin = new Padding(5, 0, 5, 0);
            LabelUangMuka.Name = "LabelUangMuka";
            LabelUangMuka.Size = new Size(159, 38);
            LabelUangMuka.TabIndex = 7;
            LabelUangMuka.Text = "Uang Muka";
            // 
            // UangMuka
            // 
            UangMuka.BackColor = Color.FromArgb(231, 231, 241);
            UangMuka.BorderStyle = BorderStyle.None;
            UangMuka.DetectUrls = false;
            UangMuka.Location = new Point(418, 507);
            UangMuka.Margin = new Padding(5);
            UangMuka.Multiline = false;
            UangMuka.Name = "UangMuka";
            UangMuka.Size = new Size(926, 64);
            UangMuka.TabIndex = 4;
            UangMuka.Text = "";
            // 
            // LabelMeja
            // 
            LabelMeja.AutoSize = true;
            LabelMeja.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMeja.Location = new Point(418, 595);
            LabelMeja.Margin = new Padding(5, 0, 5, 0);
            LabelMeja.Name = "LabelMeja";
            LabelMeja.Size = new Size(78, 38);
            LabelMeja.TabIndex = 9;
            LabelMeja.Text = "Meja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 749);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 38);
            label2.TabIndex = 11;
            label2.Text = "Metode Pembayaran";
            // 
            // Meja
            // 
            Meja.BackColor = Color.FromArgb(231, 231, 241);
            Meja.FormattingEnabled = true;
            Meja.Items.AddRange(new object[] { "No. 1", "No. 2", "No. 3", "No. 4", "No. 5", "No. 6", "No. 7", "No. 8", "No. 9", "No. 10" });
            Meja.Location = new Point(418, 651);
            Meja.Margin = new Padding(5);
            Meja.MaxDropDownItems = 10;
            Meja.Name = "Meja";
            Meja.RightToLeft = RightToLeft.No;
            Meja.Size = new Size(924, 40);
            Meja.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(231, 231, 241);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Transfer" });
            comboBox1.Location = new Point(418, 805);
            comboBox1.Margin = new Padding(5);
            comboBox1.MaxDropDownItems = 10;
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(924, 40);
            comboBox1.TabIndex = 12;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.FromArgb(90, 103, 186);
            BtnSimpan.ForeColor = Color.White;
            BtnSimpan.Location = new Point(1550, 875);
            BtnSimpan.Margin = new Padding(5);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(193, 77);
            BtnSimpan.TabIndex = 13;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.FromArgb(90, 103, 186);
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(1347, 875);
            BtnHapus.Margin = new Padding(5);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(193, 77);
            BtnHapus.TabIndex = 14;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
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
            // waiter_reservasi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1763, 1000);
            Controls.Add(btnBack);
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
            Margin = new Padding(5);
            Name = "waiter_reservasi";
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
        private Button btnBack;
    }
}