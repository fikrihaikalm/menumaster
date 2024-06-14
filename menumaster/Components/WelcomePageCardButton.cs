using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menumaster.Components
{
    public partial class WelcomePageCardButton : UserControl
    {
        private int borderRadius = 20;
        private int borderWidth = 2;
        private Color borderColor = Color.Gray;

        public WelcomePageCardButton()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        [Description("Text on the label")]
        public string CardName
        {
            get { return labelCardName.Text; }
            set { labelCardName.Text = value; }
        }

        [Category("Custom Properties")]
        [Description("Text on the button")]
        public string ButtonText
        {
            get { return buttonCardButton.Text; }
            set { buttonCardButton.Text = value; }
        }

        [Category("Custom Properties")]
        [Description("On click")]
        public event EventHandler ButtonClick
        {
            add { buttonCardButton.Click += value; }
            remove { buttonCardButton.Click -= value; }
        }


        [Category("Appearance")]
        [Description("Gets or sets the border radius of the control.")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate(); // Redraw the control when the border radius changes
            }
        }

        private void buttonCardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
