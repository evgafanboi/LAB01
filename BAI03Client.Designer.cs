namespace LAB03
{
    partial class BAI03Client
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
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Disconnectbtn = new System.Windows.Forms.Button();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(256, 12);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(440, 370);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "";
            // 
            // Connectbtn
            // 
            this.Connectbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Connectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connectbtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.Connectbtn.Location = new System.Drawing.Point(44, 39);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(162, 73);
            this.Connectbtn.TabIndex = 1;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = false;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Disconnectbtn
            // 
            this.Disconnectbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Disconnectbtn.Enabled = false;
            this.Disconnectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnectbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.Disconnectbtn.Location = new System.Drawing.Point(44, 229);
            this.Disconnectbtn.Name = "Disconnectbtn";
            this.Disconnectbtn.Size = new System.Drawing.Size(162, 73);
            this.Disconnectbtn.TabIndex = 2;
            this.Disconnectbtn.Text = "Disconnect";
            this.Disconnectbtn.UseVisualStyleBackColor = false;
            this.Disconnectbtn.Click += new System.EventHandler(this.Disconnectbtn_Click);
            // 
            // Sendbtn
            // 
            this.Sendbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sendbtn.Enabled = false;
            this.Sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.Sendbtn.Location = new System.Drawing.Point(44, 132);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(162, 73);
            this.Sendbtn.TabIndex = 3;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = false;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.Exitbtn.Location = new System.Drawing.Point(79, 327);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(87, 43);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // BAI03Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.Disconnectbtn);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.InputBox);
            this.Name = "BAI03Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Button Disconnectbtn;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}