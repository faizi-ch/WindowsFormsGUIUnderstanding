using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsGUIUnderstanding 
{
    public partial class TabControl : Form
    {
        public TabControl()
        {
            InitializeComponent();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = System.Drawing.Color.Blue;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = System.Drawing.Color.Red;
        }

        private void size12RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 12);
        }

        private void size16RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 16);
        }

        private void size20RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 20);
        }

        private void showTextButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = messageTextBox.Text;
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            displayLabel.Text = messageTextBox.Text;
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                displayLabel.Text = messageTextBox.Text;
            }
        }
    }
}
