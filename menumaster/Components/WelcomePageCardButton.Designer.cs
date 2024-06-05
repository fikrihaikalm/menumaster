namespace menumaster.Components
{
    partial class WelcomePageCardButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCardName = new Label();
            buttonCardButton = new Button();
            SuspendLayout();
            // 
            // labelCardName
            // 
            labelCardName.AutoSize = true;
            labelCardName.Dock = DockStyle.Top;
            labelCardName.Font = new Font("Arial", 16F);
            labelCardName.Location = new Point(12, 12);
            labelCardName.Margin = new Padding(4, 0, 4, 0);
            labelCardName.Name = "labelCardName";
            labelCardName.Size = new Size(98, 36);
            labelCardName.TabIndex = 0;
            labelCardName.Text = "label1";
            // 
            // buttonCardButton
            // 
            buttonCardButton.Dock = DockStyle.Bottom;
            buttonCardButton.Font = new Font("Arial", 12F);
            buttonCardButton.Location = new Point(12, 111);
            buttonCardButton.Margin = new Padding(4);
            buttonCardButton.MinimumSize = new Size(0, 62);
            buttonCardButton.Name = "buttonCardButton";
            buttonCardButton.Size = new Size(411, 62);
            buttonCardButton.TabIndex = 1;
            buttonCardButton.Text = "button1";
            buttonCardButton.UseVisualStyleBackColor = true;
            // 
            // WelcomePageCardButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonCardButton);
            Controls.Add(labelCardName);
            Margin = new Padding(4);
            Name = "WelcomePageCardButton";
            Padding = new Padding(12);
            Size = new Size(435, 185);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCardName;
        private Button buttonCardButton;
    }
}
