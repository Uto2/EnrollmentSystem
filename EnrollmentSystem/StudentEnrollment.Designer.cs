namespace EnrollmentSystem
{
    partial class StudentEnrollment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEnrollment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.TextBox();
            this.ylabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.IdNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalUnitsLabel = new System.Windows.Forms.Label();
            this.ulabel = new System.Windows.Forms.Label();
            this.EdpCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EdpCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.EncoderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateEnrollDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 60);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(121, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Enrollment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.StatusComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.YearLabel);
            this.panel2.Controls.Add(this.ylabel);
            this.panel2.Controls.Add(this.CourseLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.IdNumberTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 120);
            this.panel2.TabIndex = 1;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Enrolled",
            "Unenrolled"});
            this.StatusComboBox.Location = new System.Drawing.Point(600, 42);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(200, 21);
            this.StatusComboBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(550, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status";
            // 
            // YearLabel
            // 
            this.YearLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.YearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.YearLabel.Location = new System.Drawing.Point(600, 13);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.ReadOnly = true;
            this.YearLabel.Size = new System.Drawing.Size(200, 23);
            this.YearLabel.TabIndex = 10;
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ylabel.Location = new System.Drawing.Point(550, 13);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(35, 19);
            this.ylabel.TabIndex = 3;
            this.ylabel.Text = "Year";
            // 
            // CourseLabel
            // 
            this.CourseLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CourseLabel.Location = new System.Drawing.Point(300, 40);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.ReadOnly = true;
            this.CourseLabel.Size = new System.Drawing.Size(200, 23);
            this.CourseLabel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(250, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course";
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameLabel.Location = new System.Drawing.Point(300, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.ReadOnly = true;
            this.NameLabel.Size = new System.Drawing.Size(200, 23);
            this.NameLabel.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label.Location = new System.Drawing.Point(250, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(45, 19);
            this.label.TabIndex = 1;
            this.label.Text = "Name";
            // 
            // IdNumberTextBox
            // 
            this.IdNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdNumberTextBox.Location = new System.Drawing.Point(100, 10);
            this.IdNumberTextBox.Name = "IdNumberTextBox";
            this.IdNumberTextBox.Size = new System.Drawing.Size(120, 23);
            this.IdNumberTextBox.TabIndex = 6;
            this.IdNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNumberTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TotalUnitsLabel);
            this.panel3.Controls.Add(this.ulabel);
            this.panel3.Controls.Add(this.EdpCodeTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(20, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 250);
            this.panel3.TabIndex = 2;
            // 
            // TotalUnitsLabel
            // 
            this.TotalUnitsLabel.AutoSize = true;
            this.TotalUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TotalUnitsLabel.Location = new System.Drawing.Point(720, 220);
            this.TotalUnitsLabel.Name = "TotalUnitsLabel";
            this.TotalUnitsLabel.Size = new System.Drawing.Size(17, 19);
            this.TotalUnitsLabel.TabIndex = 13;
            this.TotalUnitsLabel.Text = "0";
            // 
            // ulabel
            // 
            this.ulabel.AutoSize = true;
            this.ulabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ulabel.Location = new System.Drawing.Point(637, 220);
            this.ulabel.Name = "ulabel";
            this.ulabel.Size = new System.Drawing.Size(77, 19);
            this.ulabel.TabIndex = 12;
            this.ulabel.Text = "Total Units:";
            // 
            // EdpCodeTextBox
            // 
            this.EdpCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdpCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EdpCodeTextBox.Location = new System.Drawing.Point(100, 10);
            this.EdpCodeTextBox.Name = "EdpCodeTextBox";
            this.EdpCodeTextBox.Size = new System.Drawing.Size(120, 23);
            this.EdpCodeTextBox.TabIndex = 9;
            this.EdpCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdpCodeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "EDP Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EdpCodeColumn,
            this.SubjectCodeColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.RoomColumn,
            this.UnitsColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(24, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(820, 112);
            this.dataGridView1.TabIndex = 5;
            // 
            // EdpCodeColumn
            // 
            this.EdpCodeColumn.HeaderText = "EDP Code";
            this.EdpCodeColumn.Name = "EdpCodeColumn";
            this.EdpCodeColumn.ReadOnly = true;
            this.EdpCodeColumn.Width = 120;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.ReadOnly = true;
            this.SubjectCodeColumn.Width = 120;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "Start Time";
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.ReadOnly = true;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "End Time";
            this.EndTimeColumn.Name = "EndTimeColumn";
            this.EndTimeColumn.ReadOnly = true;
            // 
            // DaysColumn
            // 
            this.DaysColumn.HeaderText = "Days";
            this.DaysColumn.Name = "DaysColumn";
            this.DaysColumn.ReadOnly = true;
            this.DaysColumn.Width = 80;
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "Room";
            this.RoomColumn.Name = "RoomColumn";
            this.RoomColumn.ReadOnly = true;
            this.RoomColumn.Width = 80;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.ReadOnly = true;
            this.UnitsColumn.Width = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.MenuButton);
            this.panel4.Controls.Add(this.StatusLabel);
            this.panel4.Controls.Add(this.EncoderTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.DateEnrollDateTimePicker);
            this.panel4.Controls.Add(this.Date);
            this.panel4.Controls.Add(this.CancelButton);
            this.panel4.Controls.Add(this.SaveButton);
            this.panel4.Location = new System.Drawing.Point(20, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 80);
            this.panel4.TabIndex = 3;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.White;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.MenuButton.Location = new System.Drawing.Point(762, 40);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(90, 30);
            this.MenuButton.TabIndex = 22;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.StatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.StatusLabel.Location = new System.Drawing.Point(600, 20);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 15);
            this.StatusLabel.TabIndex = 21;
            // 
            // EncoderTextBox
            // 
            this.EncoderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncoderTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EncoderTextBox.Location = new System.Drawing.Point(102, 19);
            this.EncoderTextBox.Name = "EncoderTextBox";
            this.EncoderTextBox.Size = new System.Drawing.Size(200, 23);
            this.EncoderTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Encoded By:";
            // 
            // DateEnrollDateTimePicker
            // 
            this.DateEnrollDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEnrollDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEnrollDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnrollDateTimePicker.Location = new System.Drawing.Point(406, 19);
            this.DateEnrollDateTimePicker.Name = "DateEnrollDateTimePicker";
            this.DateEnrollDateTimePicker.Size = new System.Drawing.Size(129, 23);
            this.DateEnrollDateTimePicker.TabIndex = 13;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Date.Location = new System.Drawing.Point(359, 23);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(41, 19);
            this.Date.TabIndex = 14;
            this.Date.Text = "Date:";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.CancelButton.Location = new System.Drawing.Point(666, 40);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 30);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveButton.Location = new System.Drawing.Point(570, 40);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 30);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(30, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 50);
            this.panel5.TabIndex = 1;
            // 
            // StudentEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentEnrollment";
            this.Load += new System.EventHandler(this.StudentEnrollment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ComboBox StatusComboBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox YearLabel;
    private System.Windows.Forms.Label ylabel;
    private System.Windows.Forms.TextBox CourseLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox NameLabel;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.TextBox IdNumberTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label TotalUnitsLabel;
    private System.Windows.Forms.Label ulabel;
    private System.Windows.Forms.TextBox EdpCodeTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn EdpCodeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label StatusLabel;
    private System.Windows.Forms.TextBox EncoderTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker DateEnrollDateTimePicker;
    private System.Windows.Forms.Label Date;
    private System.Windows.Forms.Button CancelButton;
    private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel panel5;
    }
}