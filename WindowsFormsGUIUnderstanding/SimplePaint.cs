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
    public partial class SimplePaint : Form
    {
        public SimplePaint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        bool pressCheck = false;
        private void SimplePaint_MouseDown(object sender, MouseEventArgs e)
        {
            pressCheck = true;
        }
        private void SimplePaint_MouseUp(object sender, MouseEventArgs e)
        {
            pressCheck = false;
        }
        private int size = 1;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Text = "Size";
            size = Convert.ToInt32(numericUpDown1.Value);
        }
        private void SimplePaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressCheck)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(new SolidBrush(colorDialog1.Color), e.X, e.Y, size, size);
            }
        }

        
    }
}
