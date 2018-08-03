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
    public partial class PictureBox_Form : Form
    {
        public PictureBox_Form()
        {
            InitializeComponent();
        }

        int n = 1;
        private void nextButton_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("image{0}", ++n));
            if (n == 3)
                n = 0;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("image{0}", --n));
            if (n == 1)
                n = 3;
        }
    }
}
