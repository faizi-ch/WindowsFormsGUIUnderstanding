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
    public partial class NumericUpDown : Form
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal principal;
            double rate;
            int year;
            decimal amount;
            string output;

            principal = Convert.ToDecimal(principalTextBox1.Text);
            rate = Convert.ToDouble(interestTextBox2.Text);
            year = Convert.ToInt32(yearNumericUpDown.Value);

            output = "Year\tAmount od Deposit\r\n";

            for (int yearCounter = 1; yearCounter <= year; yearCounter++)
            {
                amount = principal * ((decimal)Math.Pow((1 + rate / 100), yearCounter));

                output += yearCounter + "\t" + String.Format("Rs.{0:F}",amount)+"\r\n";

                outputTextBox.Text = output;
            }
        }
    }
}
