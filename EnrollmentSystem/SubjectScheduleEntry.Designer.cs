namespace EnrollmentSystem
{
    partial class SubjectScheduleEntry
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectScheduleEntry));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.AMPMComboBox = new System.Windows.Forms.ComboBox();
            this.lblAMPM = new System.Windows.Forms.Label();
            this.SchoolYearTextBox = new System.Windows.Forms.TextBox();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.TimeEndTextBox = new System.Windows.Forms.TextBox();
            this.TimeStartTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.EdpCodeTextBox = new System.Windows.Forms.TextBox();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.lblEdpCode = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.panelHeader.Controls.Add(this.panel5);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(602, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(116, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Schedule New Subject";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.AMPMComboBox);
            this.panelForm.Controls.Add(this.lblAMPM);
            this.panelForm.Controls.Add(this.SchoolYearTextBox);
            this.panelForm.Controls.Add(this.RoomTextBox);
            this.panelForm.Controls.Add(this.SectionTextBox);
            this.panelForm.Controls.Add(this.DaysTextBox);
            this.panelForm.Controls.Add(this.TimeEndTextBox);
            this.panelForm.Controls.Add(this.TimeStartTextBox);
            this.panelForm.Controls.Add(this.SubjectCodeTextBox);
            this.panelForm.Controls.Add(this.EdpCodeTextBox);
            this.panelForm.Controls.Add(this.lblSchoolYear);
            this.panelForm.Controls.Add(this.lblRoom);
            this.panelForm.Controls.Add(this.lblSection);
            this.panelForm.Controls.Add(this.lblDays);
            this.panelForm.Controls.Add(this.lblTimeEnd);
            this.panelForm.Controls.Add(this.lblTimeStart);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.DescriptionLabel);
            this.panelForm.Controls.Add(this.lblSubjectCode);
            this.panelForm.Controls.Add(this.lblEdpCode);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 60);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(30);
            this.panelForm.Size = new System.Drawing.Size(602, 471);
            this.panelForm.TabIndex = 1;
            // 
            // AMPMComboBox
            // 
            this.AMPMComboBox.BackColor = System.Drawing.Color.LightGray;
            this.AMPMComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AMPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AMPMComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMPMComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AMPMComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AMPMComboBox.FormattingEnabled = true;
            this.AMPMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMComboBox.Location = new System.Drawing.Point(430, 194);
            this.AMPMComboBox.Name = "AMPMComboBox";
            this.AMPMComboBox.Size = new System.Drawing.Size(100, 25);
            this.AMPMComboBox.TabIndex = 3;
            // 
            // lblAMPM
            // 
            this.lblAMPM.AutoSize = true;
            this.lblAMPM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAMPM.Location = new System.Drawing.Point(430, 164);
            this.lblAMPM.Name = "lblAMPM";
            this.lblAMPM.Size = new System.Drawing.Size(57, 19);
            this.lblAMPM.TabIndex = 18;
            this.lblAMPM.Text = "AM/PM";
            // 
            // SchoolYearTextBox
            // 
            this.SchoolYearTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SchoolYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SchoolYearTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SchoolYearTextBox.Location = new System.Drawing.Point(230, 354);
            this.SchoolYearTextBox.Name = "SchoolYearTextBox";
            this.SchoolYearTextBox.Size = new System.Drawing.Size(150, 25);
            this.SchoolYearTextBox.TabIndex = 9;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomTextBox.Location = new System.Drawing.Point(230, 314);
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(150, 25);
            this.RoomTextBox.TabIndex = 8;
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SectionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SectionTextBox.Location = new System.Drawing.Point(230, 274);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(80, 25);
            this.SectionTextBox.TabIndex = 7;
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DaysTextBox.Location = new System.Drawing.Point(230, 234);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(150, 25);
            this.DaysTextBox.TabIndex = 6;
            // 
            // TimeEndTextBox
            // 
            this.TimeEndTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TimeEndTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeEndTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeEndTextBox.Location = new System.Drawing.Point(230, 194);
            this.TimeEndTextBox.Name = "TimeEndTextBox";
            this.TimeEndTextBox.Size = new System.Drawing.Size(80, 25);
            this.TimeEndTextBox.TabIndex = 4;
            // 
            // TimeStartTextBox
            // 
            this.TimeStartTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TimeStartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeStartTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeStartTextBox.Location = new System.Drawing.Point(230, 154);
            this.TimeStartTextBox.Name = "TimeStartTextBox";
            this.TimeStartTextBox.Size = new System.Drawing.Size(80, 25);
            this.TimeStartTextBox.TabIndex = 2;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubjectCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(230, 80);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(150, 25);
            this.SubjectCodeTextBox.TabIndex = 1;
            this.SubjectCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectCodeTextBox_KeyPress);
            // 
            // EdpCodeTextBox
            // 
            this.EdpCodeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EdpCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdpCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EdpCodeTextBox.Location = new System.Drawing.Point(230, 40);
            this.EdpCodeTextBox.Name = "EdpCodeTextBox";
            this.EdpCodeTextBox.Size = new System.Drawing.Size(150, 25);
            this.EdpCodeTextBox.TabIndex = 0;
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSchoolYear.Location = new System.Drawing.Point(40, 357);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(82, 19);
            this.lblSchoolYear.TabIndex = 9;
            this.lblSchoolYear.Text = "School Year:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoom.Location = new System.Drawing.Point(40, 317);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(48, 19);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Room:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSection.Location = new System.Drawing.Point(40, 277);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(56, 19);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Section:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDays.Location = new System.Drawing.Point(40, 237);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(42, 19);
            this.lblDays.TabIndex = 6;
            this.lblDays.Text = "Days:";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTimeEnd.Location = new System.Drawing.Point(40, 197);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(68, 19);
            this.lblTimeEnd.TabIndex = 5;
            this.lblTimeEnd.Text = "Time End:";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTimeStart.Location = new System.Drawing.Point(40, 157);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(74, 19);
            this.lblTimeStart.TabIndex = 4;
            this.lblTimeStart.Text = "Time Start:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblDescription.Location = new System.Drawing.Point(40, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 19);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(232, 125);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(78, 19);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubjectCode.Location = new System.Drawing.Point(40, 83);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(92, 19);
            this.lblSubjectCode.TabIndex = 1;
            this.lblSubjectCode.Text = "Subject Code:";
            // 
            // lblEdpCode
            // 
            this.lblEdpCode.AutoSize = true;
            this.lblEdpCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEdpCode.Location = new System.Drawing.Point(40, 43);
            this.lblEdpCode.Name = "lblEdpCode";
            this.lblEdpCode.Size = new System.Drawing.Size(121, 19);
            this.lblEdpCode.TabIndex = 0;
            this.lblEdpCode.Text = "Subject EDP Code:";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelButtons.Controls.Add(this.btnMenu);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 461);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtons.Size = new System.Drawing.Size(602, 70);
            this.panelButtons.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnMenu.Location = new System.Drawing.Point(440, 15);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 40);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnClear.Location = new System.Drawing.Point(330, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(220, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(28, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 50);
            this.panel5.TabIndex = 23;
            // 
            // SubjectScheduleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 531);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(618, 497);
            this.Name = "SubjectScheduleEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Pro - Subject Schedule";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ComboBox AMPMComboBox;
        private System.Windows.Forms.Label lblAMPM;
        private System.Windows.Forms.TextBox SchoolYearTextBox;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.TextBox TimeEndTextBox;
        private System.Windows.Forms.TextBox TimeStartTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox EdpCodeTextBox;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.Label lblEdpCode;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel5;
    }
}