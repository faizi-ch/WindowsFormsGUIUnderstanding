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
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dateTimePicker1.Value;

            if (dropOffDate.DayOfWeek == DayOfWeek.Friday || dropOffDate.DayOfWeek == DayOfWeek.Saturday ||
                dropOffDate.DayOfWeek == DayOfWeek.Sunday)
            {
                deliveryDateTextBox.Text = dropOffDate.AddDays(3).ToLongDateString();
            }
            else
            {
                deliveryDateTextBox.Text = dropOffDate.AddDays(2).ToLongDateString();
            }
        }
    }
}
