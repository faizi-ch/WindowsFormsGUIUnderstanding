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
    public partial class MenusForm : Form
    {
        public MenusForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example of using menu item.\nMade by: Faizi", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            label.Font = new Font("Times New Roman", label.Font.Size, label.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            label.Font = new Font("Courier", label.Font.Size, label.Font.Style);
            courierToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            label.Font = new Font("Comic Sans MS", label.Font.Size, label.Font.Style);
            comicSansToolStripMenuItem.Checked = true;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Font = new Font(label.Font, label.Font.Style ^ FontStyle.Bold);
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Font = new Font(label.Font, label.Font.Style ^ FontStyle.Italic);
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
        }

        private void ClearSize()
        {
            font8.Checked = false;
            font12.Checked = false;
            font14.Checked = false;
            font18.Checked = false;
            font20.Checked = false;
            font22.Checked = false;
        }

        private void font8_Click(object sender, EventArgs e)
        {
            ClearSize();
            label.Font = new Font(label.Font.FontFamily, 8, label.Font.Style);
            font8.Checked = true;
        }

        private void font12_Click(object sender, EventArgs e)
        {
            ClearSize();
            label.Font = new Font(label.Font.FontFamily, 12, label.Font.Style);
            font12.Checked = true;
        }

        private void font14_Click(object sender, EventArgs e)
        {
            ClearSize();
            label.Font = new Font(label.Font.FontFamily, 14, label.Font.Style);
            font14.Checked = true;
        }

        private void font18_Click(object sender, EventArgs e)
        {
            ClearSize();
            label.Font = new Font(label.Font.FontFamily, 18, label.Font.Style);
            font18.Checked = true;
        }

        private void font20_Click(object sender, EventArgs e)
        {
            ClearSize();
            label.Font = new Font(label.Font.FontFamily, 20, label.Font.Style);
            font20.Checked = true;
        }

        private void font22_Click(object sender, EventArgs e)
        {
            ClearSize();
            label.Font = new Font(label.Font.FontFamily, 22, label.Font.Style);
            font22.Checked = true;
        }
    }
}