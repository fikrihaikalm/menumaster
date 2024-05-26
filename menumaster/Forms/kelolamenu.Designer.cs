namespace menumaster
{
    partial class kelolamenu
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(55, 725);
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
            label1.Location = new Point(71, 27);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 3;
            label1.Text = "Kelola Menu";
            // 
            // kelolamenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 815);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4);
            MinimumSize = new Size(994, 736);
            Name = "kelolamenu";
            Text = "kelolamenu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}