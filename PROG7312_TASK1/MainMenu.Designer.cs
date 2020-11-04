namespace PROG7312_TASK1
{
    partial class MainMenu
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
            this.btnSelectOption = new System.Windows.Forms.Button();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.rbtnFindingCallNumbers = new System.Windows.Forms.RadioButton();
            this.rbtnIdentifyingAreas = new System.Windows.Forms.RadioButton();
            this.rbtnReplacingBooks = new System.Windows.Forms.RadioButton();
            this.gbTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectOption
            // 
            this.btnSelectOption.Location = new System.Drawing.Point(100, 275);
            this.btnSelectOption.Name = "btnSelectOption";
            this.btnSelectOption.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOption.TabIndex = 0;
            this.btnSelectOption.Text = "Play";
            this.btnSelectOption.UseVisualStyleBackColor = true;
            this.btnSelectOption.Click += new System.EventHandler(this.btnSelectOption_Click);
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.rbtnFindingCallNumbers);
            this.gbTask.Controls.Add(this.rbtnIdentifyingAreas);
            this.gbTask.Controls.Add(this.rbtnReplacingBooks);
            this.gbTask.Controls.Add(this.btnSelectOption);
            this.gbTask.Location = new System.Drawing.Point(12, 21);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(272, 313);
            this.gbTask.TabIndex = 1;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Tasks";
            // 
            // rbtnFindingCallNumbers
            // 
            this.rbtnFindingCallNumbers.AutoSize = true;
            this.rbtnFindingCallNumbers.Location = new System.Drawing.Point(32, 95);
            this.rbtnFindingCallNumbers.Name = "rbtnFindingCallNumbers";
            this.rbtnFindingCallNumbers.Size = new System.Drawing.Size(110, 17);
            this.rbtnFindingCallNumbers.TabIndex = 3;
            this.rbtnFindingCallNumbers.TabStop = true;
            this.rbtnFindingCallNumbers.Text = "Find Call Numbers";
            this.rbtnFindingCallNumbers.UseVisualStyleBackColor = true;
            // 
            // rbtnIdentifyingAreas
            // 
            this.rbtnIdentifyingAreas.AutoSize = true;
            this.rbtnIdentifyingAreas.Location = new System.Drawing.Point(32, 71);
            this.rbtnIdentifyingAreas.Name = "rbtnIdentifyingAreas";
            this.rbtnIdentifyingAreas.Size = new System.Drawing.Size(105, 17);
            this.rbtnIdentifyingAreas.TabIndex = 2;
            this.rbtnIdentifyingAreas.TabStop = true;
            this.rbtnIdentifyingAreas.Text = "Identifiying Areas";
            this.rbtnIdentifyingAreas.UseVisualStyleBackColor = true;
            // 
            // rbtnReplacingBooks
            // 
            this.rbtnReplacingBooks.AutoSize = true;
            this.rbtnReplacingBooks.Location = new System.Drawing.Point(32, 47);
            this.rbtnReplacingBooks.Name = "rbtnReplacingBooks";
            this.rbtnReplacingBooks.Size = new System.Drawing.Size(106, 17);
            this.rbtnReplacingBooks.TabIndex = 1;
            this.rbtnReplacingBooks.TabStop = true;
            this.rbtnReplacingBooks.Text = "Replacing Books";
            this.rbtnReplacingBooks.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 379);
            this.Controls.Add(this.gbTask);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.gbTask.ResumeLayout(false);
            this.gbTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectOption;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.RadioButton rbtnFindingCallNumbers;
        private System.Windows.Forms.RadioButton rbtnIdentifyingAreas;
        private System.Windows.Forms.RadioButton rbtnReplacingBooks;
    }
}

