namespace PROG7312_TASK1
{
    partial class Scoreboard
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
            this.lboxScoreboard = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.rbtnReplacing = new System.Windows.Forms.RadioButton();
            this.rbtnIdentify = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxScoreboard
            // 
            this.lboxScoreboard.FormattingEnabled = true;
            this.lboxScoreboard.Location = new System.Drawing.Point(12, 139);
            this.lboxScoreboard.Name = "lboxScoreboard";
            this.lboxScoreboard.Size = new System.Drawing.Size(220, 290);
            this.lboxScoreboard.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(93, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.Location = new System.Drawing.Point(12, 123);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(62, 13);
            this.lblScoreboard.TabIndex = 2;
            this.lblScoreboard.Text = "Scoreboard";
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.rbtnIdentify);
            this.gbSelect.Controls.Add(this.rbtnReplacing);
            this.gbSelect.Location = new System.Drawing.Point(15, 13);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(217, 76);
            this.gbSelect.TabIndex = 3;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select Scoreboard";
            // 
            // rbtnReplacing
            // 
            this.rbtnReplacing.AutoSize = true;
            this.rbtnReplacing.Checked = true;
            this.rbtnReplacing.Location = new System.Drawing.Point(7, 15);
            this.rbtnReplacing.Name = "rbtnReplacing";
            this.rbtnReplacing.Size = new System.Drawing.Size(106, 17);
            this.rbtnReplacing.TabIndex = 0;
            this.rbtnReplacing.TabStop = true;
            this.rbtnReplacing.Text = "Replacing Books";
            this.rbtnReplacing.UseVisualStyleBackColor = true;
            // 
            // rbtnIdentify
            // 
            this.rbtnIdentify.AutoSize = true;
            this.rbtnIdentify.Location = new System.Drawing.Point(7, 39);
            this.rbtnIdentify.Name = "rbtnIdentify";
            this.rbtnIdentify.Size = new System.Drawing.Size(103, 17);
            this.rbtnIdentify.TabIndex = 1;
            this.rbtnIdentify.Text = "Identifying Areas";
            this.rbtnIdentify.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 96);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show scoreboard";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 484);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.lblScoreboard);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lboxScoreboard);
            this.Name = "Scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxScoreboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblScoreboard;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.RadioButton rbtnIdentify;
        private System.Windows.Forms.RadioButton rbtnReplacing;
        private System.Windows.Forms.Button btnShow;
    }
}