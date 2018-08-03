using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUIUnderstanding
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new PictureBox_Form());
            //Application.Run(new NumericUpDown());
            //Application.Run(new MouseHandling());
            //Application.Run(new KeysHandling());
            //Application.Run(new SimplePaint());
            //Application.Run(new MenusForm());
            //Application.Run(new DateTimePicker());
            //Application.Run(new LinkLabel());
            //Application.Run(new ListBox());
            //Application.Run(new CheckedListBox());
            //Application.Run(new ComboBox());
            //Application.Run(new TreeView());
            //Application.Run(new ListView());
            //Application.Run(new TabControl());
            Application.Run(new Form2());
        }
    }
}
