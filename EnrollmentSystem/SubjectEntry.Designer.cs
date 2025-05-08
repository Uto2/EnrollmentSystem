namespace EnrollmentSystem
{
    partial class SubjectEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectEntry));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRequisite = new System.Windows.Forms.Panel();
            this.CoRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.PreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.RequisiteSubjectTextBox = new System.Windows.Forms.TextBox();
            this.lblRequisiteSubject = new System.Windows.Forms.Label();
            this.lblRequisiteInfo = new System.Windows.Forms.Label();
            this.panelSubjectInfo = new System.Windows.Forms.Panel();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.OfferingComboBox = new System.Windows.Forms.ComboBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextbox = new System.Windows.Forms.TextBox();
            this.lblCurriculumYear = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblOffering = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.lblSubjectInfo = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.panelRequisite.SuspendLayout();
            this.panelSubjectInfo.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(802, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(116, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Subject Entry";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.SubjectDataGridView);
            this.panelMain.Controls.Add(this.panelRequisite);
            this.panelMain.Controls.Add(this.panelSubjectInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(802, 445);
            this.panelMain.TabIndex = 1;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.CoPreColumn});
            this.SubjectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectDataGridView.Location = new System.Drawing.Point(20, 341);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersWidth = 51;
            this.SubjectDataGridView.RowTemplate.Height = 24;
            this.SubjectDataGridView.Size = new System.Drawing.Size(762, 84);
            this.SubjectDataGridView.TabIndex = 2;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.MinimumWidth = 6;
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.ReadOnly = true;
            this.SubjectCodeColumn.Width = 125;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 250;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.MinimumWidth = 6;
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.ReadOnly = true;
            this.UnitsColumn.Width = 75;
            // 
            // CoPreColumn
            // 
            this.CoPreColumn.HeaderText = "Co/Pre-requisite";
            this.CoPreColumn.MinimumWidth = 6;
            this.CoPreColumn.Name = "CoPreColumn";
            this.CoPreColumn.ReadOnly = true;
            this.CoPreColumn.Width = 150;
            // 
            // panelRequisite
            // 
            this.panelRequisite.BackColor = System.Drawing.Color.White;
            this.panelRequisite.Controls.Add(this.CoRequisiteRadioButton);
            this.panelRequisite.Controls.Add(this.PreRequisiteRadioButton);
            this.panelRequisite.Controls.Add(this.RequisiteSubjectTextBox);
            this.panelRequisite.Controls.Add(this.lblRequisiteSubject);
            this.panelRequisite.Controls.Add(this.lblRequisiteInfo);
            this.panelRequisite.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRequisite.Location = new System.Drawing.Point(20, 220);
            this.panelRequisite.Name = "panelRequisite";
            this.panelRequisite.Padding = new System.Windows.Forms.Padding(10);
            this.panelRequisite.Size = new System.Drawing.Size(762, 121);
            this.panelRequisite.TabIndex = 1;
            // 
            // CoRequisiteRadioButton
            // 
            this.CoRequisiteRadioButton.AutoSize = true;
            this.CoRequisiteRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CoRequisiteRadioButton.Location = new System.Drawing.Point(280, 70);
            this.CoRequisiteRadioButton.Name = "CoRequisiteRadioButton";
            this.CoRequisiteRadioButton.Size = new System.Drawing.Size(90, 19);
            this.CoRequisiteRadioButton.TabIndex = 4;
            this.CoRequisiteRadioButton.TabStop = true;
            this.CoRequisiteRadioButton.Text = "Co-requisite";
            this.CoRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // PreRequisiteRadioButton
            // 
            this.PreRequisiteRadioButton.AutoSize = true;
            this.PreRequisiteRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreRequisiteRadioButton.Location = new System.Drawing.Point(280, 40);
            this.PreRequisiteRadioButton.Name = "PreRequisiteRadioButton";
            this.PreRequisiteRadioButton.Size = new System.Drawing.Size(92, 19);
            this.PreRequisiteRadioButton.TabIndex = 3;
            this.PreRequisiteRadioButton.TabStop = true;
            this.PreRequisiteRadioButton.Text = "Pre-requisite";
            this.PreRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // RequisiteSubjectTextBox
            // 
            this.RequisiteSubjectTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RequisiteSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequisiteSubjectTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RequisiteSubjectTextBox.Location = new System.Drawing.Point(130, 55);
            this.RequisiteSubjectTextBox.Name = "RequisiteSubjectTextBox";
            this.RequisiteSubjectTextBox.Size = new System.Drawing.Size(120, 25);
            this.RequisiteSubjectTextBox.TabIndex = 2;
            this.RequisiteSubjectTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequisiteSubjectTextBox_KeyPress);
            // 
            // lblRequisiteSubject
            // 
            this.lblRequisiteSubject.AutoSize = true;
            this.lblRequisiteSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRequisiteSubject.Location = new System.Drawing.Point(20, 55);
            this.lblRequisiteSubject.Name = "lblRequisiteSubject";
            this.lblRequisiteSubject.Size = new System.Drawing.Size(92, 19);
            this.lblRequisiteSubject.TabIndex = 1;
            this.lblRequisiteSubject.Text = "Subject Code:";
            // 
            // lblRequisiteInfo
            // 
            this.lblRequisiteInfo.AutoSize = true;
            this.lblRequisiteInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRequisiteInfo.Location = new System.Drawing.Point(20, 15);
            this.lblRequisiteInfo.Name = "lblRequisiteInfo";
            this.lblRequisiteInfo.Size = new System.Drawing.Size(145, 19);
            this.lblRequisiteInfo.TabIndex = 0;
            this.lblRequisiteInfo.Text = "Requisite Information";
            // 
            // panelSubjectInfo
            // 
            this.panelSubjectInfo.BackColor = System.Drawing.Color.White;
            this.panelSubjectInfo.Controls.Add(this.CurriculumYearTextBox);
            this.panelSubjectInfo.Controls.Add(this.CourseCodeComboBox);
            this.panelSubjectInfo.Controls.Add(this.CategoryComboBox);
            this.panelSubjectInfo.Controls.Add(this.OfferingComboBox);
            this.panelSubjectInfo.Controls.Add(this.UnitsTextBox);
            this.panelSubjectInfo.Controls.Add(this.DescriptionTextBox);
            this.panelSubjectInfo.Controls.Add(this.SubjectCodeTextbox);
            this.panelSubjectInfo.Controls.Add(this.lblCurriculumYear);
            this.panelSubjectInfo.Controls.Add(this.lblCourseCode);
            this.panelSubjectInfo.Controls.Add(this.lblCategory);
            this.panelSubjectInfo.Controls.Add(this.lblOffering);
            this.panelSubjectInfo.Controls.Add(this.lblUnits);
            this.panelSubjectInfo.Controls.Add(this.lblDescription);
            this.panelSubjectInfo.Controls.Add(this.lblSubjectCode);
            this.panelSubjectInfo.Controls.Add(this.lblSubjectInfo);
            this.panelSubjectInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjectInfo.Location = new System.Drawing.Point(20, 20);
            this.panelSubjectInfo.Name = "panelSubjectInfo";
            this.panelSubjectInfo.Padding = new System.Windows.Forms.Padding(10);
            this.panelSubjectInfo.Size = new System.Drawing.Size(762, 200);
            this.panelSubjectInfo.TabIndex = 0;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CurriculumYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurriculumYearTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(620, 150);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(100, 25);
            this.CurriculumYearTextBox.TabIndex = 7;
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CourseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseCodeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseCodeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(620, 110);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(120, 25);
            this.CourseCodeComboBox.TabIndex = 6;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Lecture",
            "Laboratory"});
            this.CategoryComboBox.Location = new System.Drawing.Point(620, 70);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(120, 25);
            this.CategoryComboBox.TabIndex = 5;
            // 
            // OfferingComboBox
            // 
            this.OfferingComboBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.OfferingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfferingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfferingComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OfferingComboBox.FormattingEnabled = true;
            this.OfferingComboBox.Items.AddRange(new object[] {
            "First Semester",
            "Second Semester",
            "Summer"});
            this.OfferingComboBox.Location = new System.Drawing.Point(620, 30);
            this.OfferingComboBox.Name = "OfferingComboBox";
            this.OfferingComboBox.Size = new System.Drawing.Size(120, 25);
            this.OfferingComboBox.TabIndex = 4;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UnitsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitsTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UnitsTextBox.Location = new System.Drawing.Point(130, 150);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(50, 25);
            this.UnitsTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(130, 110);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(300, 25);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // SubjectCodeTextbox
            // 
            this.SubjectCodeTextbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubjectCodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectCodeTextbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubjectCodeTextbox.Location = new System.Drawing.Point(130, 70);
            this.SubjectCodeTextbox.Name = "SubjectCodeTextbox";
            this.SubjectCodeTextbox.Size = new System.Drawing.Size(120, 25);
            this.SubjectCodeTextbox.TabIndex = 1;
            // 
            // lblCurriculumYear
            // 
            this.lblCurriculumYear.AutoSize = true;
            this.lblCurriculumYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurriculumYear.Location = new System.Drawing.Point(480, 150);
            this.lblCurriculumYear.Name = "lblCurriculumYear";
            this.lblCurriculumYear.Size = new System.Drawing.Size(109, 19);
            this.lblCurriculumYear.TabIndex = 6;
            this.lblCurriculumYear.Text = "Curriculum Year:";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourseCode.Location = new System.Drawing.Point(480, 110);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(91, 19);
            this.lblCourseCode.TabIndex = 5;
            this.lblCourseCode.Text = "Course Code:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(480, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 19);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // lblOffering
            // 
            this.lblOffering.AutoSize = true;
            this.lblOffering.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOffering.Location = new System.Drawing.Point(480, 30);
            this.lblOffering.Name = "lblOffering";
            this.lblOffering.Size = new System.Drawing.Size(62, 19);
            this.lblOffering.TabIndex = 3;
            this.lblOffering.Text = "Offering:";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnits.Location = new System.Drawing.Point(20, 150);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(44, 19);
            this.lblUnits.TabIndex = 2;
            this.lblUnits.Text = "Units:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(20, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 19);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubjectCode.Location = new System.Drawing.Point(20, 70);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(92, 19);
            this.lblSubjectCode.TabIndex = 0;
            this.lblSubjectCode.Text = "Subject Code:";
            // 
            // lblSubjectInfo
            // 
            this.lblSubjectInfo.AutoSize = true;
            this.lblSubjectInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubjectInfo.Location = new System.Drawing.Point(20, 20);
            this.lblSubjectInfo.Name = "lblSubjectInfo";
            this.lblSubjectInfo.Size = new System.Drawing.Size(134, 19);
            this.lblSubjectInfo.TabIndex = 0;
            this.lblSubjectInfo.Text = "Subject Information";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelButtons.Controls.Add(this.btnMenu);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 505);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelButtons.Size = new System.Drawing.Size(802, 70);
            this.panelButtons.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnMenu.Location = new System.Drawing.Point(640, 15);
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
            this.btnClear.Location = new System.Drawing.Point(530, 15);
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
            this.btnSave.Location = new System.Drawing.Point(420, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(28, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 50);
            this.panel5.TabIndex = 23;
            // 
            // SubjectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 575);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(818, 597);
            this.Name = "SubjectEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Pro - Subject Entry";
            this.Load += new System.EventHandler(this.SubjectEntry_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.panelRequisite.ResumeLayout(false);
            this.panelRequisite.PerformLayout();
            this.panelSubjectInfo.ResumeLayout(false);
            this.panelSubjectInfo.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPreColumn;
        private System.Windows.Forms.Panel panelRequisite;
        private System.Windows.Forms.RadioButton CoRequisiteRadioButton;
        private System.Windows.Forms.RadioButton PreRequisiteRadioButton;
        private System.Windows.Forms.TextBox RequisiteSubjectTextBox;
        private System.Windows.Forms.Label lblRequisiteSubject;
        private System.Windows.Forms.Label lblRequisiteInfo;
        private System.Windows.Forms.Panel panelSubjectInfo;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox OfferingComboBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextbox;
        private System.Windows.Forms.Label lblCurriculumYear;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblOffering;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.Label lblSubjectInfo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel5;
    }
}