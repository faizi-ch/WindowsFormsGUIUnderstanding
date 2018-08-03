﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUIUnderstanding
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private string currentDirectory = Directory.GetCurrentDirectory();

        private void listView1_Click(object sender, EventArgs e)
        {
            if (browserListView.SelectedItems.Count != 0)
            {
                // if first item selected, go up one level
                if (browserListView.Items[0].Selected)
                {
                    // create DirectoryInfo object for directory
                    DirectoryInfo directoryObject =
                        new DirectoryInfo(currentDirectory);

                    // if directory has parent, load it
                    if (directoryObject.Parent != null)
                    {
                        LoadFilesInDirectory(
                            directoryObject.Parent.FullName);
                    } // end if
                } // end if

                // selected directory or file
                else
                {
                    // directory or file chosen
                    string chosen = browserListView.SelectedItems[0].Text;

                    // if item selected is directory, load selected directory
                    if (Directory.Exists(
                        Path.Combine(currentDirectory, chosen)))
                    {
                        LoadFilesInDirectory(
                            Path.Combine(currentDirectory, chosen));
                    } // end if
                } // end else

                // update displayLabel
                displayLabel.Text = currentDirectory;
            } // end if
        } // end method browserListView_Click

        // display files/subdirectories of current directory
        public void LoadFilesInDirectory(string currentDirectoryValue)
        {
            // load directory information and display
            try
            {
                // clear ListView and set first item

                browserListView.Items.Clear();
                browserListView.Items.Add("Go Up One Level");
                // update current directory
                currentDirectory = currentDirectoryValue;
                DirectoryInfo newCurrentDirectory =
                    new DirectoryInfo(currentDirectory);

// put files and directories into arrays
                DirectoryInfo[] directoryArray =
                    newCurrentDirectory.GetDirectories();
                FileInfo[] fileArray = newCurrentDirectory.GetFiles();

                // add directory names to ListView
                foreach (DirectoryInfo dir in directoryArray)
                {
                    // add directory to ListView
                    ListViewItem newDirectoryItem =
                        browserListView.Items.Add(dir.Name);
                    newDirectoryItem.ImageIndex = 0; // set directory image


                } // end foreach

                // add file names to ListView
                foreach (FileInfo file in fileArray)
                {
                    // add file to ListView
                    ListViewItem newFileItem =
                        browserListView.Items.Add(file.Name);
                    newFileItem.ImageIndex = 1; // set file image
                } // end foreach
            } // end try

                // access denied
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: Some fields may not be " +
                                "visible due to permission settings",
                    "Attention", 0, MessageBoxIcon.Warning);
            } // end catch
        } // end method LoadFilesInDirectory

        private void ListView_Load(object sender, EventArgs e)
        {
            LoadFilesInDirectory(currentDirectory);
            displayLabel.Text = currentDirectory;

        }
    }
}
