namespace LAB03
{
    partial class BAI06Client
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
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ComboBoxReceiver = new System.Windows.Forms.ComboBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ListViewOutput = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.ButtonSendFile = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Enabled = false;
            this.TextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMessage.Location = new System.Drawing.Point(150, 329);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(305, 31);
            this.TextBoxMessage.TabIndex = 1;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Enabled = false;
            this.ButtonSend.Location = new System.Drawing.Point(461, 329);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(97, 31);
            this.ButtonSend.TabIndex = 2;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ComboBoxReceiver
            // 
            this.ComboBoxReceiver.Enabled = false;
            this.ComboBoxReceiver.FormattingEnabled = true;
            this.ComboBoxReceiver.Items.AddRange(new object[] {
            "*"});
            this.ComboBoxReceiver.Location = new System.Drawing.Point(13, 393);
            this.ComboBoxReceiver.Name = "ComboBoxReceiver";
            this.ComboBoxReceiver.Size = new System.Drawing.Size(118, 21);
            this.ComboBoxReceiver.TabIndex = 3;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(470, 11);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(97, 23);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ListViewOutput
            // 
            this.ListViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.Message});
            this.ListViewOutput.HideSelection = false;
            this.ListViewOutput.Location = new System.Drawing.Point(22, 40);
            this.ListViewOutput.Name = "ListViewOutput";
            this.ListViewOutput.Size = new System.Drawing.Size(536, 262);
            this.ListViewOutput.TabIndex = 5;
            this.ListViewOutput.UseCompatibleStateImageBehavior = false;
            this.ListViewOutput.View = System.Windows.Forms.View.Details;
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 87;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 478;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(13, 329);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(118, 31);
            this.TextBoxName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Send To";
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Enabled = false;
            this.TextBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFilePath.Location = new System.Drawing.Point(150, 387);
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.ReadOnly = true;
            this.TextBoxFilePath.Size = new System.Drawing.Size(305, 31);
            this.TextBoxFilePath.TabIndex = 10;
            // 
            // ButtonSendFile
            // 
            this.ButtonSendFile.Enabled = false;
            this.ButtonSendFile.Location = new System.Drawing.Point(461, 387);
            this.ButtonSendFile.Name = "ButtonSendFile";
            this.ButtonSendFile.Size = new System.Drawing.Size(97, 31);
            this.ButtonSendFile.TabIndex = 11;
            this.ButtonSendFile.Text = "Send File";
            this.ButtonSendFile.UseVisualStyleBackColor = true;
            this.ButtonSendFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Enabled = false;
            this.ButtonReset.Location = new System.Drawing.Point(13, 11);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(97, 23);
            this.ButtonReset.TabIndex = 12;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // BAI06Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 435);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSendFile);
            this.Controls.Add(this.TextBoxFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewOutput);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ComboBoxReceiver);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.TextBoxMessage);
            this.Name = "BAI06Client";
            this.Text = "BAI06Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.ComboBox ComboBoxReceiver;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ListView ListViewOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFilePath;
        private System.Windows.Forms.Button ButtonSendFile;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Button ButtonReset;
    }
}