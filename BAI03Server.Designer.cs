namespace LAB03
{
    partial class BAI03Server
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
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Listenbtn = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.Exitbtn.Location = new System.Drawing.Point(76, 327);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(87, 43);
            this.Exitbtn.TabIndex = 9;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Resetbtn.Enabled = false;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.LightCoral;
            this.Resetbtn.Location = new System.Drawing.Point(41, 144);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(162, 73);
            this.Resetbtn.TabIndex = 7;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Listenbtn
            // 
            this.Listenbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Listenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listenbtn.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Listenbtn.Location = new System.Drawing.Point(41, 39);
            this.Listenbtn.Name = "Listenbtn";
            this.Listenbtn.Size = new System.Drawing.Size(162, 73);
            this.Listenbtn.TabIndex = 6;
            this.Listenbtn.Text = "Listen";
            this.Listenbtn.UseVisualStyleBackColor = false;
            this.Listenbtn.Click += new System.EventHandler(this.Listenbtn_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(256, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(440, 370);
            this.OutputBox.TabIndex = 5;
            this.OutputBox.Text = "";
            // 
            // BAI03Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Listenbtn);
            this.Controls.Add(this.OutputBox);
            this.Name = "BAI03Server";
            this.Text = "BAI03Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Listenbtn;
        private System.Windows.Forms.RichTextBox OutputBox;
    }
}