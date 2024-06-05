namespace menumaster.Views
{
    partial class waiter_pesanan
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
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.ActiveCaption;
            btnSimpan.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(598, 382);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(174, 46);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // waiter_pesanan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Name = "waiter_pesanan";
            Text = "waiter_pesanan";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimpan;
    }
}