namespace BTTH2
{
    partial class BAI06View
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
            this.label4 = new System.Windows.Forms.Label();
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListMA = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(352, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preview ảnh:";
            // 
            // ImagePreview
            // 
            this.ImagePreview.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImagePreview.Location = new System.Drawing.Point(286, 177);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(313, 223);
            this.ImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreview.TabIndex = 12;
            this.ImagePreview.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(504, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListMA
            // 
            this.ListMA.BackColor = System.Drawing.Color.Bisque;
            this.ListMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMA.FormattingEnabled = true;
            this.ListMA.ItemHeight = 20;
            this.ListMA.Location = new System.Drawing.Point(21, 28);
            this.ListMA.Name = "ListMA";
            this.ListMA.Size = new System.Drawing.Size(227, 364);
            this.ListMA.TabIndex = 16;
            this.ListMA.SelectedIndexChanged += new System.EventHandler(this.ListMA_SelectedIndexChanged);
            // 
            // BAI06View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.ListMA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImagePreview);
            this.Name = "BAI06View";
            this.Text = "BAI06View";
            this.Load += new System.EventHandler(this.BAI06View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListMA;
    }
}