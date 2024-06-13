namespace menumaster
{
    partial class WelcomePageForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            welcomePageCardAdmin = new Components.WelcomePageCardButton();
            welcomePageCardManager = new Components.WelcomePageCardButton();
            welcomePageCardKasir = new Components.WelcomePageCardButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            welcomePageCardButton1 = new Components.WelcomePageCardButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomePageCardAdmin
            // 
            welcomePageCardAdmin.Anchor = AnchorStyles.None;
            welcomePageCardAdmin.BorderRadius = 20;
            welcomePageCardAdmin.BorderStyle = BorderStyle.FixedSingle;
            welcomePageCardAdmin.ButtonText = "Lanjutkan Sebagai Admin";
            welcomePageCardAdmin.CardName = "Admin";
            welcomePageCardAdmin.Location = new Point(42, 394);
            welcomePageCardAdmin.Margin = new Padding(16, 18, 16, 18);
            welcomePageCardAdmin.Name = "welcomePageCardAdmin";
            welcomePageCardAdmin.Padding = new Padding(16, 18, 16, 18);
            welcomePageCardAdmin.Size = new Size(527, 214);
            welcomePageCardAdmin.TabIndex = 8;
            welcomePageCardAdmin.ButtonClick += adminButton_Click;
            // 
            // welcomePageCardManager
            // 
            welcomePageCardManager.Anchor = AnchorStyles.None;
            welcomePageCardManager.BorderRadius = 20;
            welcomePageCardManager.BorderStyle = BorderStyle.FixedSingle;
            welcomePageCardManager.ButtonText = "Lanjutkan Sebagai Manager";
            welcomePageCardManager.CardName = "Manager";
            welcomePageCardManager.Location = new Point(622, 394);
            welcomePageCardManager.Margin = new Padding(16, 18, 16, 18);
            welcomePageCardManager.Name = "welcomePageCardManager";
            welcomePageCardManager.Padding = new Padding(16, 18, 16, 18);
            welcomePageCardManager.Size = new Size(527, 214);
            welcomePageCardManager.TabIndex = 10;
            welcomePageCardManager.ButtonClick += managerButton_Click;
            welcomePageCardManager.Load += welcomePageCardManager_Load;
            // 
            // welcomePageCardKasir
            // 
            welcomePageCardKasir.Anchor = AnchorStyles.None;
            welcomePageCardKasir.BorderRadius = 20;
            welcomePageCardKasir.BorderStyle = BorderStyle.FixedSingle;
            welcomePageCardKasir.ButtonText = "Lanjutkan Sebagai Waiter";
            welcomePageCardKasir.CardName = "Waiter";
            welcomePageCardKasir.Location = new Point(1203, 394);
            welcomePageCardKasir.Margin = new Padding(16, 18, 16, 18);
            welcomePageCardKasir.Name = "welcomePageCardKasir";
            welcomePageCardKasir.Padding = new Padding(16, 18, 16, 18);
            welcomePageCardKasir.Size = new Size(527, 214);
            welcomePageCardKasir.TabIndex = 11;
            welcomePageCardKasir.ButtonClick += kasirButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(welcomePageCardKasir, 2, 1);
            tableLayoutPanel1.Controls.Add(welcomePageCardManager, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(welcomePageCardAdmin, 0, 1);
            tableLayoutPanel1.Controls.Add(welcomePageCardButton1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(16, 18, 16, 18);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1773, 1005);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(318, 23);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 200);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1136, 160);
            label1.TabIndex = 3;
            label1.Text = "Selamat Datang";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(484, 160);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 40);
            label2.TabIndex = 4;
            label2.Text = "Silahkan Login";
            // 
            // welcomePageCardButton1
            // 
            welcomePageCardButton1.Anchor = AnchorStyles.None;
            welcomePageCardButton1.BorderRadius = 20;
            welcomePageCardButton1.BorderStyle = BorderStyle.FixedSingle;
            welcomePageCardButton1.ButtonText = "Lanjutkan Sebagai Chef";
            welcomePageCardButton1.CardName = "Chef";
            welcomePageCardButton1.Location = new Point(622, 717);
            welcomePageCardButton1.Margin = new Padding(16, 18, 16, 18);
            welcomePageCardButton1.Name = "welcomePageCardButton1";
            welcomePageCardButton1.Padding = new Padding(16, 18, 16, 18);
            welcomePageCardButton1.Size = new Size(527, 214);
            welcomePageCardButton1.TabIndex = 13;
            welcomePageCardButton1.ButtonClick += chefButton_Click;
            welcomePageCardButton1.Load += welcomePageCardButton1_Load;
            // 
            // WelcomePageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1773, 1005);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(1284, 920);
            Name = "WelcomePageForm";
            Text = "welcome page";
            WindowState = FormWindowState.Maximized;
            Load += WelcomePageForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Components.WelcomePageCardButton welcomePageCardAdmin;
        private Components.WelcomePageCardButton welcomePageCardButton2;
        private Components.WelcomePageCardButton welcomePageCardManager;
        private Components.WelcomePageCardButton welcomePageCardKasir;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Components.WelcomePageCardButton welcomePageCardButton1;
    }
}