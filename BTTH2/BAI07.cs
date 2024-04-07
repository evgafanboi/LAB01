using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace BTTH2
{
    public partial class BAI07 : Form
    {
        public BAI07()
        {
            InitializeComponent();
            //add root node are the drives
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo Drive in allDrives)
            {
                TreeNode root = new TreeNode(Drive.Name);
                root.Name = Drive.Name;
                TreeViewFileTree.Nodes.Add(root);
                //add dummy node to the root node
                root.Nodes.Add(new TreeNode());
                TreeViewFileTree_LoadExplorer(root);
            }

        }

        private void TreeViewFileTree_LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
               // show error message
               MessageBox.Show("Thư mục không tồn tại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // clear all dummy children nodes
            root.Nodes.Clear();

            // if root is a file, return

            if (Directory.Exists(root.Name))
            {
                try
                {
                    foreach (string files in Directory.EnumerateFiles(root.Name))
                    {
                        TreeNode temp2 = new TreeNode(Path.GetFileName(files));
                        temp2.Name = files;
                        root.Nodes.Add(temp2);
                    }

                }

                catch
                {
                    //catch if the directory is not accessible, skip it
                    return;
                }

                // same for directories
                try
                {
                    foreach (string directory in Directory.EnumerateDirectories(root.Name))
                    {
                        TreeNode temp = new TreeNode(new DirectoryInfo(directory).Name);
                        temp.Name = directory;
                        root.Nodes.Add(temp);
                        
                        // check if the current directory has subdirectories
                        if (Directory.EnumerateDirectories(directory).Count() > 0 || Directory.EnumerateFiles(directory).Count() > 0)
                        {
                            // add a dummy node to the current node
                            temp.Nodes.Add(new TreeNode());
                        }

                    }
                }

                catch
                {
                    return;
                }
            }




            
        }

        private void BAI07_Load(object sender, EventArgs e)
        {

        }

        private void TreeViewFileTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
                TreeViewFileTree_LoadExplorer(e.Node);
                TextBoxPath.Text = e.Node.Name;
        }

        private void TreeViewFileTree_DoubleClick(object sender, EventArgs e)
        {
            // check if user double click on a node
            if (TreeViewFileTree.SelectedNode != null)
            {
                // if a node is a image file, show it in the picture box
                if (Path.GetExtension(TreeViewFileTree.SelectedNode.Name) == ".jpg" || Path.GetExtension(TreeViewFileTree.SelectedNode.Name) == ".png" || Path.GetExtension(TreeViewFileTree.SelectedNode.Name) == ".bmp" || Path.GetExtension(TreeViewFileTree.SelectedNode.Name) == ".tiff" || Path.GetExtension(TreeViewFileTree.SelectedNode.Name) == ".gif")
                    PictureBoxImage.Image = Image.FromFile(TreeViewFileTree.SelectedNode.Name);
                else
                    PictureBoxImage.Image = null;
            }

        }

    }
}
