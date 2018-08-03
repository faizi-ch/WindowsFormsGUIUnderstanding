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
    public partial class Form1 : Form
    {
        private MessageBoxButtons messageBoxButtons;
        private MessageBoxIcon messageBoxIcon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
            
            
        }
        
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            //MessageBox.Show("Your password is: {0}", t);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleLabel.Font=new Font(fontStyleLabel.Font,fontStyleLabel.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleLabel.Font = new Font(fontStyleLabel.Font, fontStyleLabel.Font.Style ^ FontStyle.Italic);
        }

        private void strikeoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleLabel.Font=new Font(fontStyleLabel.Font,fontStyleLabel.Font.Style ^ FontStyle.Strikeout);
        }

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleLabel.Font=new Font(fontStyleLabel.Font,fontStyleLabel.Font.Style ^ FontStyle.Underline);
        }

        private void buttonTypleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender==okRadioButton)
                messageBoxButtons=MessageBoxButtons.OK;
            else if(sender==okCanRadioButton)
                messageBoxButtons=MessageBoxButtons.OKCancel;
            else if (sender == abRtIgRadioButton)
                messageBoxButtons = MessageBoxButtons.AbortRetryIgnore;
            else if(sender==yesNoCanRadioButton)
                messageBoxButtons=MessageBoxButtons.YesNoCancel;
            else if(sender==yesNoRadioButton)
                messageBoxButtons=MessageBoxButtons.YesNo;
            else if(sender==retCanRadioButton)
                messageBoxButtons=MessageBoxButtons.RetryCancel;
        }

        private void iconTypleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton)
                messageBoxIcon = MessageBoxIcon.Asterisk;
            else if(sender==errorRadioButton)
                messageBoxIcon=MessageBoxIcon.Error;
            else if(sender==exclamRadioButton)
                messageBoxIcon=MessageBoxIcon.Exclamation;
            else if(sender==handRadioButton)
                messageBoxIcon=MessageBoxIcon.Hand;
            else if(sender==infoRadioButton)
                messageBoxIcon=MessageBoxIcon.Information;
            else if(sender==quesRadioButton)
                messageBoxIcon=MessageBoxIcon.Question;
            else if(sender==stopRadioButton)
                messageBoxIcon=MessageBoxIcon.Stop;
            else 
                messageBoxIcon=MessageBoxIcon.Warning;
        }

        private void msgBoxDisplayButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("This is your message box","Custom Message Box",messageBoxButtons,messageBoxIcon);

            switch (dialogResult)
            {

                case DialogResult.Abort:
                    msgBxTextBox.Text = "Abort is pressed.";
                    break;

                case DialogResult.Cancel:
                    msgBxTextBox.Text = "Cancel is pressed.";
                    break;

                case DialogResult.Ignore:
                    msgBxTextBox.Text = "Ignore is pressed.";
                    break;

                case DialogResult.No:
                    msgBxTextBox.Text = "No is pressed.";
                    break;

                case DialogResult.None:
                    msgBxTextBox.Text = "None is pressed.";
                    break;

                case DialogResult.OK:
                    msgBxTextBox.Text = "OK is pressed.";
                    break;

                case DialogResult.Yes:
                    msgBxTextBox.Text = "Yes is pressed.";
                    break;
            }
        }
       
    }
}