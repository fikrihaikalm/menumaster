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
            textBoxAlamat = new TextBox();
            textBoxTelp = new TextBox();
            textBoxNama = new TextBox();
            textBoxID = new TextBox();
            labelAlamat = new Label();
            labelTelp = new Label();
            labelNama = new Label();
            labelID = new Label();
            labelTitle = new Label();
            checkBoxAktif = new CheckBox();
            textBoxFoto = new TextBox();
            labelFoto = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            dateTimePickerTglMasuk = new DateTimePicker();
            labelTglMasuk = new Label();
            textBoxGaji = new TextBox();
            labelGaji = new Label();
            comboBoxRole = new ComboBox();
            labelRole = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LimeGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(876, 722);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 45);
            button2.TabIndex = 21;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSimpan_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(350, 722);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 45);
            button1.TabIndex = 20;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Anchor = AnchorStyles.None;
            textBoxAlamat.Location = new Point(592, 314);
            textBoxAlamat.Margin = new Padding(4, 5, 4, 5);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(391, 31);
            textBoxAlamat.TabIndex = 19;
            // 
            // textBoxTelp
            // 
            textBoxTelp.Anchor = AnchorStyles.None;
            textBoxTelp.Location = new Point(592, 249);
            textBoxTelp.Margin = new Padding(4, 5, 4, 5);
            textBoxTelp.Name = "textBoxTelp";
            textBoxTelp.Size = new Size(391, 31);
            textBoxTelp.TabIndex = 18;
            // 
            // textBoxNama
            // 
            textBoxNama.Anchor = AnchorStyles.None;
            textBoxNama.Location = new Point(592, 185);
            textBoxNama.Margin = new Padding(4, 5, 4, 5);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(391, 31);
            textBoxNama.TabIndex = 17;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.None;
            textBoxID.Location = new Point(592, 125);
            textBoxID.Margin = new Padding(4, 5, 4, 5);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(391, 31);
            textBoxID.TabIndex = 16;
            // 
            // labelAlamat
            // 
            labelAlamat.Anchor = AnchorStyles.None;
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelAlamat.Location = new Point(350, 315);
            labelAlamat.Margin = new Padding(4, 0, 4, 0);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(89, 27);
            labelAlamat.TabIndex = 15;
            labelAlamat.Text = "Alamat";
            // 
            // labelTelp
            // 
            labelTelp.Anchor = AnchorStyles.None;
            labelTelp.AutoSize = true;
            labelTelp.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelTelp.Location = new Point(350, 250);
            labelTelp.Margin = new Padding(4, 0, 4, 0);
            labelTelp.Name = "labelTelp";
            labelTelp.Size = new Size(180, 27);
            labelTelp.TabIndex = 14;
            labelTelp.Text = "Nomor Telepon";
            // 
            // labelNama
            // 
            labelNama.Anchor = AnchorStyles.None;
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelNama.Location = new Point(350, 187);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(74, 27);
            labelNama.TabIndex = 13;
            labelNama.Text = "Nama";
            // 
            // labelID
            // 
            labelID.Anchor = AnchorStyles.None;
            labelID.AutoSize = true;
            labelID.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelID.Location = new Point(350, 127);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(34, 27);
            labelID.TabIndex = 12;
            labelID.Text = "ID";
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(552, 31);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(378, 34);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Mengubah Data Karyawan";
            // 
            // checkBoxAktif
            // 
            checkBoxAktif.Anchor = AnchorStyles.None;
            checkBoxAktif.Location = new Point(1003, 635);
            checkBoxAktif.Margin = new Padding(4, 5, 4, 5);
            checkBoxAktif.Name = "checkBoxAktif";
            checkBoxAktif.Size = new Size(149, 40);
            checkBoxAktif.TabIndex = 22;
            checkBoxAktif.Text = "Aktif";
            checkBoxAktif.UseVisualStyleBackColor = true;
            // 
            // textBoxFoto
            // 
            textBoxFoto.Anchor = AnchorStyles.None;
            textBoxFoto.Location = new Point(592, 359);
            textBoxFoto.Margin = new Padding(4, 5, 4, 5);
            textBoxFoto.Name = "textBoxFoto";
            textBoxFoto.Size = new Size(391, 31);
            textBoxFoto.TabIndex = 23;
            // 
            // labelFoto
            // 
            labelFoto.Anchor = AnchorStyles.None;
            labelFoto.AutoSize = true;
            labelFoto.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelFoto.Location = new Point(350, 360);
            labelFoto.Margin = new Padding(4, 0, 4, 0);
            labelFoto.Name = "labelFoto";
            labelFoto.Size = new Size(62, 27);
            labelFoto.TabIndex = 24;
            labelFoto.Text = "Foto";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(592, 415);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(391, 31);
            textBoxPassword.TabIndex = 25;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelPassword.Location = new Point(350, 416);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(122, 27);
            labelPassword.TabIndex = 26;
            labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Location = new Point(592, 471);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(391, 31);
            textBoxEmail.TabIndex = 27;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelEmail.Location = new Point(350, 472);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 27);
            labelEmail.TabIndex = 28;
            labelEmail.Text = "Email";
            // 
            // dateTimePickerTglMasuk
            // 
            dateTimePickerTglMasuk.Anchor = AnchorStyles.None;
            dateTimePickerTglMasuk.Enabled = false;
            dateTimePickerTglMasuk.Location = new Point(592, 527);
            dateTimePickerTglMasuk.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerTglMasuk.Name = "dateTimePickerTglMasuk";
            dateTimePickerTglMasuk.Size = new Size(391, 31);
            dateTimePickerTglMasuk.TabIndex = 29;
            // 
            // labelTglMasuk
            // 
            labelTglMasuk.Anchor = AnchorStyles.None;
            labelTglMasuk.AutoSize = true;
            labelTglMasuk.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelTglMasuk.Location = new Point(350, 528);
            labelTglMasuk.Margin = new Padding(4, 0, 4, 0);
            labelTglMasuk.Name = "labelTglMasuk";
            labelTglMasuk.Size = new Size(180, 27);
            labelTglMasuk.TabIndex = 30;
            labelTglMasuk.Text = "Tanggal Masuk";
            // 
            // textBoxGaji
            // 
            textBoxGaji.Anchor = AnchorStyles.None;
            textBoxGaji.Location = new Point(592, 583);
            textBoxGaji.Margin = new Padding(4, 5, 4, 5);
            textBoxGaji.Name = "textBoxGaji";
            textBoxGaji.Size = new Size(391, 31);
            textBoxGaji.TabIndex = 31;
            // 
            // labelGaji
            // 
            labelGaji.Anchor = AnchorStyles.None;
            labelGaji.AutoSize = true;
            labelGaji.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelGaji.Location = new Point(350, 584);
            labelGaji.Margin = new Padding(4, 0, 4, 0);
            labelGaji.Name = "labelGaji";
            labelGaji.Size = new Size(57, 27);
            labelGaji.TabIndex = 32;
            labelGaji.Text = "Gaji";
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.None;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(592, 639);
            comboBoxRole.Margin = new Padding(4, 5, 4, 5);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(391, 33);
            comboBoxRole.TabIndex = 33;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.None;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelRole.Location = new Point(350, 640);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(63, 27);
            labelRole.TabIndex = 34;
            labelRole.Text = "Role";
            // 
            // Manager_UbahKaryawan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 885);
            Controls.Add(labelRole);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxGaji);
            Controls.Add(labelGaji);
            Controls.Add(dateTimePickerTglMasuk);
            Controls.Add(labelTglMasuk);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxFoto);
            Controls.Add(labelFoto);
            Controls.Add(checkBoxAktif);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxAlamat);
            Controls.Add(textBoxTelp);
            Controls.Add(textBoxNama);
            Controls.Add(textBoxID);
            Controls.Add(labelAlamat);
            Controls.Add(labelTelp);
            Controls.Add(labelNama);
            Controls.Add(labelID);
            Controls.Add(labelTitle);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(993, 729);
            Name = "Manager_UbahKaryawan";
            Text = "Manager Ubah Karyawan";
            TopMost = true;
            Load += Manager_UbahKaryawan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBoxAlamat;
        private TextBox textBoxTelp;
        private TextBox textBoxNama;
        private TextBox textBoxID;
        private Label labelAlamat;
        private Label labelTelp;
        private Label labelNama;
        private Label labelID;
        private Label labelTitle;
        private CheckBox checkBoxAktif;
        private TextBox textBoxFoto;
        private Label labelFoto;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private DateTimePicker dateTimePickerTglMasuk;
        private Label labelTglMasuk;
        private TextBox textBoxGaji;
        private Label labelGaji;
        private ComboBox comboBoxRole;
        private Label labelRole;
    }
}
