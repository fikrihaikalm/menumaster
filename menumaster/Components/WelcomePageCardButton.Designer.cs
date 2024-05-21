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
            labelCardName.Location = new Point(10, 10);
            labelCardName.Name = "labelCardName";
            labelCardName.Size = new Size(86, 32);
            labelCardName.TabIndex = 0;
            labelCardName.Text = "label1";
            // 
            // buttonCardButton
            // 
            buttonCardButton.Dock = DockStyle.Bottom;
            buttonCardButton.Font = new Font("Arial", 12F);
            buttonCardButton.Location = new Point(10, 88);
            buttonCardButton.MinimumSize = new Size(0, 50);
            buttonCardButton.Name = "buttonCardButton";
            buttonCardButton.Size = new Size(328, 50);
            buttonCardButton.TabIndex = 1;
            buttonCardButton.Text = "button1";
            buttonCardButton.UseVisualStyleBackColor = true;
            // 
            // WelcomePageCardButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonCardButton);
            Controls.Add(labelCardName);
            Name = "WelcomePageCardButton";
            Padding = new Padding(10);
            Size = new Size(348, 148);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCardName;
        private Button buttonCardButton;
    }
}
