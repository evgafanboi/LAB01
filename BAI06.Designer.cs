namespace LAB03
{
    partial class BAI06
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
            this.ButtonClient = new System.Windows.Forms.Button();
            this.ButtonServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClient
            // 
            this.ButtonClient.Location = new System.Drawing.Point(12, 139);
            this.ButtonClient.Name = "ButtonClient";
            this.ButtonClient.Size = new System.Drawing.Size(113, 61);
            this.ButtonClient.TabIndex = 0;
            this.ButtonClient.Text = "Client";
            this.ButtonClient.UseVisualStyleBackColor = true;
            this.ButtonClient.Click += new System.EventHandler(this.ButtonClient_Click);
            // 
            // ButtonServer
            // 
            this.ButtonServer.Location = new System.Drawing.Point(209, 139);
            this.ButtonServer.Name = "ButtonServer";
            this.ButtonServer.Size = new System.Drawing.Size(113, 61);
            this.ButtonServer.TabIndex = 1;
            this.ButtonServer.Text = "Server";
            this.ButtonServer.UseVisualStyleBackColor = true;
            this.ButtonServer.Click += new System.EventHandler(this.ButtonServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "BAI06";
            // 
            // BAI06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonServer);
            this.Controls.Add(this.ButtonClient);
            this.Name = "BAI06";
            this.Text = "BAI06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClient;
        private System.Windows.Forms.Button ButtonServer;
        private System.Windows.Forms.Label label1;
    }
}