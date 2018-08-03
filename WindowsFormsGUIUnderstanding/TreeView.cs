using System;
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
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private string substringDirectory; // store last part of full path name

        public void PopulateTreeView(
            string directoryValue, TreeNode parentNode)
        {
// array stores all subdirectories in the directory
            string[] directoryArray =
                Directory.GetDirectories(directoryValue);

// populate current node with subdirectories
            try
            {
                // check to see if any subdirectories are present
                if (directoryArray.Length != 0)
                {
                    // for every subdirectory, create new TreeNode,
                    // add as a child of current node and recursively
                    // populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        // obtain last part of path name from the full path
                        // name by calling the GetFileNameWithoutExtension
                        // method of class Path
                        substringDirectory =
                            Path.GetFileNameWithoutExtension(directory);

                        // create TreeNode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        // add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        // recursively populate every subdirectory
                        PopulateTreeView(directory, myNode);
                    } // end foreach
                } // end if
            } //end try

                // catch exception
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            } // end catch
        } // end method PopulateTreeView

        private void enterButton_Click(object sender, EventArgs e)
        {
            directoryTreeView.Nodes.Clear();

            if (Directory.Exists(inputTextBox.Text))
            {
                directoryTreeView.Nodes.Add(inputTextBox.Text);

                PopulateTreeView(inputTextBox.Text, directoryTreeView.Nodes[0]);
            }
            else
                MessageBox.Show(inputTextBox.Text + " could not be found.", "Directory Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}