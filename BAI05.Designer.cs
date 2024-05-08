namespace LAB03
{
    partial class BAI05
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
            this.ServerOpenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerOpenbtn.Location = new System.Drawing.Point(107, 37);
            this.ServerOpenbtn.Name = "ServerOpenbtn";
            this.ServerOpenbtn.Size = new System.Drawing.Size(151, 63);
            this.ServerOpenbtn.TabIndex = 0;
            this.ServerOpenbtn.Text = "Open server (TCP)";
            this.ServerOpenbtn.UseVisualStyleBackColor = true;
            this.ServerOpenbtn.Click += new System.EventHandler(this.ServerOpenbtn_Click);
            // 
            // NewClientbtn
            // 
            this.NewClientbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClientbtn.Location = new System.Drawing.Point(107, 124);
            this.NewClientbtn.Name = "NewClientbtn";
            this.NewClientbtn.Size = new System.Drawing.Size(151, 63);
            this.NewClientbtn.TabIndex = 1;
            this.NewClientbtn.Text = "New client (TCP)";
            this.NewClientbtn.UseVisualStyleBackColor = true;
            this.NewClientbtn.Click += new System.EventHandler(this.NewClientbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Red;
            this.Exitbtn.Location = new System.Drawing.Point(278, 199);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(63, 27);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // BAI05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(353, 238);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.NewClientbtn);
            this.Controls.Add(this.ServerOpenbtn);
            this.Name = "BAI05";
            this.Text = "BAI05";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ServerOpenbtn;
        private System.Windows.Forms.Button NewClientbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}