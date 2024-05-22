namespace LAB04
{
    partial class BAI07
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
            Randomizebtn = new Button();
            AddFoodbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            TabView = new TabControl();
            AllTabPage = new TabPage();
            AllFoodFlow = new FlowLayoutPanel();
            SelfTabView = new TabPage();
            MyFoodFlow = new FlowLayoutPanel();
            statusStrip1 = new StatusStrip();
            UserWelcomeLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            LogOutLabel = new ToolStripStatusLabel();
            ProgressBar = new ToolStripProgressBar();
            label3 = new Label();
            label4 = new Label();
            PageCapCB = new ComboBox();
            CurrentPageCB = new ComboBox();
<<<<<<< HEAD
=======
            Deletebtn = new Button();
>>>>>>> 24b7506 (BAI07 finalized)
            TabView.SuspendLayout();
            AllTabPage.SuspendLayout();
            SelfTabView.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Randomizebtn
            // 
            Randomizebtn.Font = new Font("Segoe UI", 10.2F);
            Randomizebtn.ForeColor = Color.DarkSlateGray;
            Randomizebtn.Location = new Point(351, 85);
            Randomizebtn.Name = "Randomizebtn";
            Randomizebtn.Size = new Size(120, 66);
            Randomizebtn.TabIndex = 21;
            Randomizebtn.Text = "Ăn gì đây?";
            Randomizebtn.UseVisualStyleBackColor = true;
            Randomizebtn.Click += Randomizebtn_Click;
            // 
            // AddFoodbtn
            // 
            AddFoodbtn.Enabled = false;
            AddFoodbtn.Font = new Font("Segoe UI", 10.2F);
            AddFoodbtn.ForeColor = Color.DarkSlateGray;
            AddFoodbtn.Location = new Point(489, 85);
            AddFoodbtn.Name = "AddFoodbtn";
            AddFoodbtn.Size = new Size(120, 66);
            AddFoodbtn.TabIndex = 19;
            AddFoodbtn.Text = "Thêm món ăn";
            AddFoodbtn.UseVisualStyleBackColor = true;
            AddFoodbtn.Click += AddFoodbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(350, -48);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 16;
            label1.Text = "BÀI 03";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(46, 56);
            label2.Name = "label2";
            label2.Size = new Size(267, 46);
            label2.TabIndex = 23;
            label2.Text = "Hôm nay ăn gì?";
            // 
            // TabView
            // 
            TabView.Controls.Add(AllTabPage);
            TabView.Controls.Add(SelfTabView);
            TabView.Location = new Point(42, 173);
            TabView.Name = "TabView";
            TabView.SelectedIndex = 0;
            TabView.Size = new Size(589, 557);
            TabView.TabIndex = 24;
            TabView.SelectedIndexChanged += TabView_SelectedIndexChanged;
            // 
            // AllTabPage
            // 
            AllTabPage.Controls.Add(AllFoodFlow);
            AllTabPage.Location = new Point(4, 29);
            AllTabPage.Name = "AllTabPage";
            AllTabPage.Padding = new Padding(3);
            AllTabPage.Size = new Size(581, 524);
            AllTabPage.TabIndex = 0;
            AllTabPage.Text = "Tất cả";
            AllTabPage.UseVisualStyleBackColor = true;
            // 
            // AllFoodFlow
            // 
            AllFoodFlow.AutoScroll = true;
            AllFoodFlow.Location = new Point(0, 0);
            AllFoodFlow.Name = "AllFoodFlow";
            AllFoodFlow.Size = new Size(581, 521);
            AllFoodFlow.TabIndex = 0;
            // 
            // SelfTabView
            // 
            SelfTabView.Controls.Add(MyFoodFlow);
            SelfTabView.Location = new Point(4, 29);
            SelfTabView.Name = "SelfTabView";
            SelfTabView.Padding = new Padding(3);
            SelfTabView.Size = new Size(581, 524);
            SelfTabView.TabIndex = 1;
            SelfTabView.Text = "Của tôi";
            SelfTabView.UseVisualStyleBackColor = true;
            SelfTabView.Click += SelfTabView_Click;
            // 
            // MyFoodFlow
            // 
            MyFoodFlow.AutoScroll = true;
            MyFoodFlow.Location = new Point(0, 2);
            MyFoodFlow.Name = "MyFoodFlow";
            MyFoodFlow.Size = new Size(581, 521);
            MyFoodFlow.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { UserWelcomeLabel, toolStripStatusLabel2, LogOutLabel, ProgressBar });
            statusStrip1.Location = new Point(0, 796);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(668, 26);
            statusStrip1.TabIndex = 25;
            statusStrip1.Text = "statusStrip1";
            // 
            // UserWelcomeLabel
            // 
            UserWelcomeLabel.BackColor = Color.Gray;
            UserWelcomeLabel.ForeColor = Color.LimeGreen;
            UserWelcomeLabel.Name = "UserWelcomeLabel";
            UserWelcomeLabel.Size = new Size(118, 20);
            UserWelcomeLabel.Text = "Anonymous user";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // LogOutLabel
            // 
            LogOutLabel.BackColor = Color.Gray;
            LogOutLabel.IsLink = true;
            LogOutLabel.LinkColor = Color.Red;
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(33, 20);
            LogOutLabel.Text = "Exit";
            LogOutLabel.Click += LogOutLabel_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.Margin = new Padding(6, 4, 1, 4);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(100, 18);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(310, 754);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 26;
            label3.Text = "Page";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(462, 754);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 27;
            label4.Text = "Page size";
            // 
            // PageCapCB
            // 
            PageCapCB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageCapCB.ForeColor = Color.DarkSlateGray;
            PageCapCB.FormattingEnabled = true;
            PageCapCB.Items.AddRange(new object[] { "3", "4", "5", "6", "7" });
            PageCapCB.Location = new Point(559, 751);
            PageCapCB.Name = "PageCapCB";
            PageCapCB.Size = new Size(72, 31);
            PageCapCB.TabIndex = 28;
            PageCapCB.Text = "5";
            PageCapCB.SelectedIndexChanged += PageCapCB_SelectedIndexChanged;
            // 
            // CurrentPageCB
            // 
            CurrentPageCB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentPageCB.ForeColor = Color.DarkSlateGray;
            CurrentPageCB.FormattingEnabled = true;
            CurrentPageCB.Items.AddRange(new object[] { "1" });
            CurrentPageCB.Location = new Point(370, 751);
            CurrentPageCB.Name = "CurrentPageCB";
            CurrentPageCB.Size = new Size(72, 31);
            CurrentPageCB.TabIndex = 29;
            CurrentPageCB.Text = "1";
            CurrentPageCB.SelectedIndexChanged += CurrentPageCB_SelectedIndexChanged;
            // 
<<<<<<< HEAD
=======
            // Deletebtn
            // 
            Deletebtn.Enabled = false;
            Deletebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.Red;
            Deletebtn.Location = new Point(42, 753);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(149, 29);
            Deletebtn.TabIndex = 30;
            Deletebtn.Text = "Xóa món ăn ";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
>>>>>>> 24b7506 (BAI07 finalized)
            // BAI07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(668, 822);
<<<<<<< HEAD
=======
            Controls.Add(Deletebtn);
>>>>>>> 24b7506 (BAI07 finalized)
            Controls.Add(PageCapCB);
            Controls.Add(CurrentPageCB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(statusStrip1);
            Controls.Add(TabView);
            Controls.Add(label2);
            Controls.Add(Randomizebtn);
            Controls.Add(AddFoodbtn);
            Controls.Add(label1);
            Name = "BAI07";
            Text = "BAI07";
            TabView.ResumeLayout(false);
            AllTabPage.ResumeLayout(false);
            SelfTabView.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Randomizebtn;
        private Button AddFoodbtn;
        private Label label1;
        private Label label2;
        private TabControl TabView;
        private TabPage SelfTabView;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel UserWelcomeLabel;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel LogOutLabel;
        private ToolStripProgressBar ProgressBar;
        private Label label3;
        private Label label4;
        private ComboBox PageCapCB;
        private ComboBox CurrentPageCB;
        private TabPage AllTabPage;
        private FlowLayoutPanel AllFoodFlow;
        private FlowLayoutPanel MyFoodFlow;
<<<<<<< HEAD
=======
        private Button Deletebtn;
>>>>>>> 24b7506 (BAI07 finalized)
    }
}