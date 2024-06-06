namespace menumaster
{
<<<<<<< HEAD:menumaster/Forms/kelolamenu.Designer.cs
    partial class KelolaMenu
=======
    partial class admin_kelolamenu
>>>>>>> dbeeba6735644caf6eb1d3cd33bfb5814de6869c:menumaster/Views/admin_kelolamenu.Designer.cs
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
<<<<<<< HEAD:menumaster/Forms/kelolamenu.Designer.cs
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaMenu));
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kelolamenu));
>>>>>>> dbeeba6735644caf6eb1d3cd33bfb5814de6869c:menumaster/Views/admin_kelolamenu.Designer.cs
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ID = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            UbahHapus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(14, 748);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(135, 54);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 3;
            label1.Text = "Kelola Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD:menumaster/Forms/kelolamenu.Designer.cs
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Foto, Nama, Harga, Deskripsi, UbahHapus });
            dataGridView1.Location = new Point(106, 128);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(946, 160);
=======
            dataGridView1.Location = new Point(28, 72);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1328, 636);
>>>>>>> dbeeba6735644caf6eb1d3cd33bfb5814de6869c:menumaster/Views/admin_kelolamenu.Designer.cs
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.ep_back;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 764);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
<<<<<<< HEAD:menumaster/Forms/kelolamenu.Designer.cs
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.MinimumWidth = 8;
            Foto.Name = "Foto";
            Foto.Width = 150;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 8;
            Nama.Name = "Nama";
            Nama.Width = 150;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 8;
            Harga.Name = "Harga";
            Harga.Width = 150;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 8;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Width = 150;
            // 
            // UbahHapus
            // 
            UbahHapus.HeaderText = "Ubah atau Hapus";
            UbahHapus.MinimumWidth = 8;
            UbahHapus.Name = "UbahHapus";
            UbahHapus.Width = 150;
            // 
            // KelolaMenu
=======
            // admin_kelolamenu
>>>>>>> dbeeba6735644caf6eb1d3cd33bfb5814de6869c:menumaster/Views/admin_kelolamenu.Designer.cs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 815);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
<<<<<<< HEAD:menumaster/Forms/kelolamenu.Designer.cs
            Margin = new Padding(4);
            MinimumSize = new Size(994, 736);
            Name = "KelolaMenu";
=======
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(993, 734);
            Name = "admin_kelolamenu";
>>>>>>> dbeeba6735644caf6eb1d3cd33bfb5814de6869c:menumaster/Views/admin_kelolamenu.Designer.cs
            Text = "kelolamenu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewButtonColumn UbahHapus;
    }
}