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
    public partial class KeysHandling : Form
    {
        public KeysHandling()
        {
            InitializeComponent();
        }

        private void KeysHandling_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCharLabel.Text = "Key pressed: "+e.KeyChar;
        }

        private void KeysHandling_KeyDown(object sender, KeyEventArgs e)
        {
            altLabel.Text = (e.Alt ? "Alt: Yes" : "Alt: No");
            ctrlLabel.Text = e.Control ? "Ctrl: Yes" : "Ctrl: No";
            shiftLabel.Text = e.Shift ? "Shift: Yes" : "Shift: No";
            keyCodeLabel.Text = "KeyCode: " + e.KeyCode;
            keyDataLabel.Text = "KeyData: " + e.KeyData;
            keyValueLabel.Text = "KeyValue: " + e.KeyValue;
        }
    }
}
