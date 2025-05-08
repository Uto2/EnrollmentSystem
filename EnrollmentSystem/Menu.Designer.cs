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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.ScheduleEntry = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEnrollmentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.StudentEntryButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.StudentEntryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentEntryButton.Location = new System.Drawing.Point(287, 101);
            this.StudentEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(220, 51);
            this.StudentEntryButton.TabIndex = 0;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click_1);
            // 
            // ScheduleEntry
            // 
            this.ScheduleEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.ScheduleEntry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ScheduleEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.ScheduleEntry.Location = new System.Drawing.Point(287, 259);
            this.ScheduleEntry.Name = "ScheduleEntry";
            this.ScheduleEntry.Size = new System.Drawing.Size(220, 51);
            this.ScheduleEntry.TabIndex = 2;
            this.ScheduleEntry.Text = "Schedule Entry";
            this.ScheduleEntry.UseVisualStyleBackColor = false;
            this.ScheduleEntry.Click += new System.EventHandler(this.ScheduleEntry_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.SubjectEntryButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SubjectEntryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SubjectEntryButton.Location = new System.Drawing.Point(287, 180);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(220, 51);
            this.SubjectEntryButton.TabIndex = 3;
            this.SubjectEntryButton.Text = "Subject Entry";
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // StudentEnrollmentButton
            // 
            this.StudentEnrollmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.StudentEnrollmentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.StudentEnrollmentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentEnrollmentButton.Location = new System.Drawing.Point(287, 329);
            this.StudentEnrollmentButton.Name = "StudentEnrollmentButton";
            this.StudentEnrollmentButton.Size = new System.Drawing.Size(220, 51);
            this.StudentEnrollmentButton.TabIndex = 4;
            this.StudentEnrollmentButton.Text = "Schedule Enrollment";
            this.StudentEnrollmentButton.UseVisualStyleBackColor = false;
            this.StudentEnrollmentButton.Click += new System.EventHandler(this.StudentEnrollmentButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 60);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enrolment System Menu";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(50, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentEnrollmentButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.ScheduleEntry);
            this.Controls.Add(this.StudentEntryButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button ScheduleEntry;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button StudentEnrollmentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}