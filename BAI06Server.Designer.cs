namespace LAB03
{
    partial class BAI06Server
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
            this.ListViewOutput = new System.Windows.Forms.ListView();
            this.ButtonListen = new System.Windows.Forms.Button();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewOutput
            // 
            this.ListViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.Message});
            this.ListViewOutput.HideSelection = false;
            this.ListViewOutput.Location = new System.Drawing.Point(37, 66);
            this.ListViewOutput.Name = "ListViewOutput";
            this.ListViewOutput.Size = new System.Drawing.Size(536, 262);
            this.ListViewOutput.TabIndex = 16;
            this.ListViewOutput.UseCompatibleStateImageBehavior = false;
            this.ListViewOutput.View = System.Windows.Forms.View.Details;
            // 
            // ButtonListen
            // 
            this.ButtonListen.Location = new System.Drawing.Point(246, 348);
            this.ButtonListen.Name = "ButtonListen";
            this.ButtonListen.Size = new System.Drawing.Size(97, 31);
            this.ButtonListen.TabIndex = 13;
            this.ButtonListen.Text = "Listen";
            this.ButtonListen.UseVisualStyleBackColor = true;
            this.ButtonListen.Click += new System.EventHandler(this.ButtonListen_Click);
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 105;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 427;
            // 
            // BAI06Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 488);
            this.Controls.Add(this.ListViewOutput);
            this.Controls.Add(this.ButtonListen);
            this.Name = "BAI06Server";
            this.Text = "BAI06Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewOutput;
        private System.Windows.Forms.Button ButtonListen;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Message;
    }
}