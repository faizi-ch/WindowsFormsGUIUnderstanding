using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUIUnderstanding
{
    public partial class MouseHandling : Form
    {
        public MouseHandling()
        {
            InitializeComponent();
        }

        private void MouseHandling_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor=Color.Aqua;
        }

        private void MouseHandling_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            buttonLabel.Text = "";
            clicksLabel.Text = "";
            clicksCount = 0;
        }
        int clicksCount = 0;
        private void MouseHandling_MouseDown(object sender, MouseEventArgs e)
        {
            string btn;
            
            //clicksCount += e.Clicks;
            btn = e.Button + " is pressed " + " at " + String.Format("[{0}][{1}]", e.X, e.Y);
            buttonLabel.Text = btn;
            clicksLabel.Text = "Clicks: " + (++clicksCount);
        }
    }
}
