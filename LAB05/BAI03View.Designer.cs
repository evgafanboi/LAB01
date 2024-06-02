namespace LAB05
{
    partial class BAI03View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Okbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(26, 48);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(591, 297);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // Okbtn
            // 
            this.Okbtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.ForeColor = System.Drawing.Color.Bisque;
            this.Okbtn.Location = new System.Drawing.Point(278, 366);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(86, 32);
            this.Okbtn.TabIndex = 1;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = false;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // BAI03View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(644, 415);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.Output);
            this.Name = "BAI03View";
            this.Load += new System.EventHandler(this.BAI03View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Okbtn;
    }
}
