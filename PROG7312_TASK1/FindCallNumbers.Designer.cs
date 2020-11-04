namespace PROG7312_TASK1
{
    partial class FindCallNumbers
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
            this.btnStart = new System.Windows.Forms.Button();
            this.gbTopLevelOptions = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbtnOption1 = new System.Windows.Forms.RadioButton();
            this.rbtnOption2 = new System.Windows.Forms.RadioButton();
            this.rbtnOption3 = new System.Windows.Forms.RadioButton();
            this.rbtnOption4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblForMarking = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.gbTopLevelOptions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(212, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbTopLevelOptions
            // 
            this.gbTopLevelOptions.Controls.Add(this.lblScore);
            this.gbTopLevelOptions.Controls.Add(this.btnNext);
            this.gbTopLevelOptions.Controls.Add(this.btnSubmit);
            this.gbTopLevelOptions.Controls.Add(this.rbtnOption4);
            this.gbTopLevelOptions.Controls.Add(this.rbtnOption3);
            this.gbTopLevelOptions.Controls.Add(this.rbtnOption2);
            this.gbTopLevelOptions.Controls.Add(this.rbtnOption1);
            this.gbTopLevelOptions.Controls.Add(this.lblQuestion);
            this.gbTopLevelOptions.Location = new System.Drawing.Point(12, 130);
            this.gbTopLevelOptions.Name = "gbTopLevelOptions";
            this.gbTopLevelOptions.Size = new System.Drawing.Size(429, 244);
            this.gbTopLevelOptions.TabIndex = 2;
            this.gbTopLevelOptions.TabStop = false;
            this.gbTopLevelOptions.Text = "Top Level Options";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(22, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // rbtnOption1
            // 
            this.rbtnOption1.AutoSize = true;
            this.rbtnOption1.Location = new System.Drawing.Point(25, 69);
            this.rbtnOption1.Name = "rbtnOption1";
            this.rbtnOption1.Size = new System.Drawing.Size(85, 17);
            this.rbtnOption1.TabIndex = 5;
            this.rbtnOption1.TabStop = true;
            this.rbtnOption1.Text = "radioButton1";
            this.rbtnOption1.UseVisualStyleBackColor = true;
            // 
            // rbtnOption2
            // 
            this.rbtnOption2.AutoSize = true;
            this.rbtnOption2.Location = new System.Drawing.Point(25, 92);
            this.rbtnOption2.Name = "rbtnOption2";
            this.rbtnOption2.Size = new System.Drawing.Size(85, 17);
            this.rbtnOption2.TabIndex = 6;
            this.rbtnOption2.TabStop = true;
            this.rbtnOption2.Text = "radioButton2";
            this.rbtnOption2.UseVisualStyleBackColor = true;
            // 
            // rbtnOption3
            // 
            this.rbtnOption3.AutoSize = true;
            this.rbtnOption3.Location = new System.Drawing.Point(25, 115);
            this.rbtnOption3.Name = "rbtnOption3";
            this.rbtnOption3.Size = new System.Drawing.Size(85, 17);
            this.rbtnOption3.TabIndex = 7;
            this.rbtnOption3.TabStop = true;
            this.rbtnOption3.Text = "radioButton3";
            this.rbtnOption3.UseVisualStyleBackColor = true;
            // 
            // rbtnOption4
            // 
            this.rbtnOption4.AutoSize = true;
            this.rbtnOption4.Location = new System.Drawing.Point(25, 138);
            this.rbtnOption4.Name = "rbtnOption4";
            this.rbtnOption4.Size = new System.Drawing.Size(85, 17);
            this.rbtnOption4.TabIndex = 8;
            this.rbtnOption4.TabStop = true;
            this.rbtnOption4.Text = "radioButton4";
            this.rbtnOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(25, 172);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(25, 202);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(287, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score:";
            // 
            // lblForMarking
            // 
            this.lblForMarking.AutoSize = true;
            this.lblForMarking.Location = new System.Drawing.Point(12, 405);
            this.lblForMarking.Name = "lblForMarking";
            this.lblForMarking.Size = new System.Drawing.Size(63, 13);
            this.lblForMarking.TabIndex = 3;
            this.lblForMarking.Text = "For Marking";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.highScoreToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // highScoreToolStripMenuItem
            // 
            this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highScoreToolStripMenuItem.Text = "High score";
            this.highScoreToolStripMenuItem.Click += new System.EventHandler(this.highScoreToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(16, 63);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User:";
            // 
            // txtbUser
            // 
            this.txtbUser.Location = new System.Drawing.Point(61, 60);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(133, 20);
            this.txtbUser.TabIndex = 9;
            // 
            // FindCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 441);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.lblForMarking);
            this.Controls.Add(this.gbTopLevelOptions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FindCallNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Call Numbers";
            this.gbTopLevelOptions.ResumeLayout(false);
            this.gbTopLevelOptions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbTopLevelOptions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbtnOption4;
        private System.Windows.Forms.RadioButton rbtnOption3;
        private System.Windows.Forms.RadioButton rbtnOption2;
        private System.Windows.Forms.RadioButton rbtnOption1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblForMarking;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtbUser;
    }
}