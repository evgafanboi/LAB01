namespace LAB04
{
    partial class BAI07RandomWindow
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
            Panel = new Panel();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Location = new Point(0, 1);
            Panel.Name = "Panel";
            Panel.Size = new Size(606, 166);
            Panel.TabIndex = 0;
            // 
            // BAI07RandomWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 167);
            Controls.Add(Panel);
            Name = "BAI07RandomWindow";
            Text = "?";
            Load += BAI07RandomWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
    }
}