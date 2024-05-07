namespace LAB03
{
    partial class BAI03
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
            this.ServerOpenbtn = new System.Windows.Forms.Button();
            this.NewClientbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerOpenbtn
            // 
            this.ServerOpenbtn.Location = new System.Drawing.Point(52, 39);
            this.ServerOpenbtn.Name = "ServerOpenbtn";
            this.ServerOpenbtn.Size = new System.Drawing.Size(294, 89);
            this.ServerOpenbtn.TabIndex = 0;
            this.ServerOpenbtn.Text = "Open TCP Server";
            this.ServerOpenbtn.UseVisualStyleBackColor = true;
            this.ServerOpenbtn.Click += new System.EventHandler(this.OpenServerbtn_Click);
            // 
            // NewClientbtn
            // 
            this.NewClientbtn.Location = new System.Drawing.Point(52, 163);
            this.NewClientbtn.Name = "NewClientbtn";
            this.NewClientbtn.Size = new System.Drawing.Size(294, 89);
            this.NewClientbtn.TabIndex = 1;
            this.NewClientbtn.Text = "Open new TCP Client";
            this.NewClientbtn.UseVisualStyleBackColor = true;
            this.NewClientbtn.Click += new System.EventHandler(this.NewClientbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(131, 276);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(125, 52);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // BAI03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 340);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.NewClientbtn);
            this.Controls.Add(this.ServerOpenbtn);
            this.Name = "BAI03";
            this.Text = "BAI03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ServerOpenbtn;
        private System.Windows.Forms.Button NewClientbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}