namespace BTTH2
{
    partial class BAI07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeViewFileTree = new System.Windows.Forms.TreeView();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewFileTree
            // 
            this.TreeViewFileTree.Location = new System.Drawing.Point(12, 42);
            this.TreeViewFileTree.Name = "TreeViewFileTree";
            this.TreeViewFileTree.Size = new System.Drawing.Size(211, 396);
            this.TreeViewFileTree.TabIndex = 0;
            this.TreeViewFileTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewFileTree_AfterExpand);
            this.TreeViewFileTree.DoubleClick += new System.EventHandler(this.TreeViewFileTree_DoubleClick);
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(12, 12);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.ReadOnly = true;
            this.TextBoxPath.Size = new System.Drawing.Size(725, 20);
            this.TextBoxPath.TabIndex = 1;
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.Location = new System.Drawing.Point(229, 42);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(508, 396);
            this.PictureBoxImage.TabIndex = 2;
            this.PictureBoxImage.TabStop = false;
            // 
            // BAI07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 451);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.TextBoxPath);
            this.Controls.Add(this.TreeViewFileTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BAI07";
            this.Text = "BAI07";
            this.Load += new System.EventHandler(this.BAI07_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewFileTree;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.PictureBox PictureBoxImage;
    }
}