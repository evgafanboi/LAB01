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

namespace BTTH2
{
    public partial class BAI07 : Form
    {
        public BAI07()
        {
            InitializeComponent();
            //TreeNode root = new TreeNode("C:\\");
            //set node to current user desktop
            //TreeNode root = new TreeNode(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            TreeNode root = new TreeNode("D:\\Tai_Lieu_Hoc\\LTHDT");


            TreeViewFileTree.Nodes.Add(root);
            TreeViewFileTree_LoadExplorer(root);
            
        }

        private void TreeViewFileTree_LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
               // show error message
               MessageBox.Show("Thư mục không tồn tại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // if root is a file, return

            if (Directory.Exists(root.Text))
            {
                try
                {
                    foreach (string files in Directory.EnumerateFiles(root.Text))
                    {
                        TreeNode temp2 = new TreeNode(Path.GetFileName(files));
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
                    foreach (string directory in Directory.EnumerateDirectories(root.Text))
                    {
                        TreeNode temp = new TreeNode(Path.GetDirectoryName(directory));
                        root.Nodes.Add(temp);
                        // need to fix why it doesn't show the subdirectories                        
                        .//
                        //
                        //

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
        }
    }
}
