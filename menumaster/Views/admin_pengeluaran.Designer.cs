﻿namespace menumaster
{
    partial class admin_pengeluaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_pengeluaran));
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 0;
            label1.Text = "Pengeluaran";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(11, 596);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.ep_back;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 608);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(194, 114);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(691, 423);
            dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(196, 73);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(486, 74);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(241, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(785, 73);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 7;
            button2.Text = "Tampilkan";
            button2.UseVisualStyleBackColor = false;
            // 
            // admin_pengeluaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 650);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            MinimumSize = new Size(798, 597);
            Name = "admin_pengeluaran";
            Text = "Pengeluaran";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
    }
}