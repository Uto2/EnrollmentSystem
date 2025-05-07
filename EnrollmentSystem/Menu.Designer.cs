namespace EnrollmentSystem
{
    partial class Menu
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
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScheduleEntry = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.Location = new System.Drawing.Point(254, 128);
            this.StudentEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(98, 34);
            this.StudentEntryButton.TabIndex = 0;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = true;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // ScheduleEntry
            // 
            this.ScheduleEntry.Location = new System.Drawing.Point(254, 243);
            this.ScheduleEntry.Name = "ScheduleEntry";
            this.ScheduleEntry.Size = new System.Drawing.Size(98, 34);
            this.ScheduleEntry.TabIndex = 2;
            this.ScheduleEntry.Text = "Schedule Entry";
            this.ScheduleEntry.UseVisualStyleBackColor = true;
            this.ScheduleEntry.Click += new System.EventHandler(this.ScheduleEntry_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.Location = new System.Drawing.Point(254, 186);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(98, 34);
            this.SubjectEntryButton.TabIndex = 3;
            this.SubjectEntryButton.Text = "Subject Entry";
            this.SubjectEntryButton.UseVisualStyleBackColor = true;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 439);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.ScheduleEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentEntryButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScheduleEntry;
        private System.Windows.Forms.Button SubjectEntryButton;
    }
}