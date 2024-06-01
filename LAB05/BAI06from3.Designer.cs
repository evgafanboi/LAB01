namespace LAB05
{
    partial class BAI06from3
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
            this.ButtonReply = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonReply
            // 
            this.ButtonReply.Location = new System.Drawing.Point(356, 407);
            this.ButtonReply.Name = "ButtonReply";
            this.ButtonReply.Size = new System.Drawing.Size(75, 23);
            this.ButtonReply.TabIndex = 9;
            this.ButtonReply.Text = "Reply";
            this.ButtonReply.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(37, 50);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(50, 16);
            this.LabelTitle.TabIndex = 8;
            this.LabelTitle.Text = "label3";
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(376, 20);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(35, 13);
            this.LabelTo.TabIndex = 7;
            this.LabelTo.Text = "label2";
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Location = new System.Drawing.Point(37, 20);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(35, 13);
            this.LabelFrom.TabIndex = 6;
            this.LabelFrom.Text = "label1";
            // 
            // BAI06from3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReply);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.LabelFrom);
            this.Name = "BAI06from3";
            this.Text = "BAI06from3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReply;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Label LabelFrom;
    }
}