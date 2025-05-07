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
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EdpCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNumberTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.TextBox();
            this.EdpCodeTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.TextBox();
            this.TotalUnitsLabel = new System.Windows.Forms.TextBox();
            this.ulabel = new System.Windows.Forms.Label();
            this.DateEnrollDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EncoderTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(144, 95);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(358, 135);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(29, 13);
            this.ylabel.TabIndex = 3;
            this.ylabel.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EDP Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EdpCodeColumn,
            this.SubjectCodeColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.RoomColumn,
            this.UnitsColumn});
            this.dataGridView1.Location = new System.Drawing.Point(40, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 128);
            this.dataGridView1.TabIndex = 5;
            // 
            // EdpCodeColumn
            // 
            this.EdpCodeColumn.HeaderText = "Edp Code";
            this.EdpCodeColumn.Name = "EdpCodeColumn";
            this.EdpCodeColumn.ReadOnly = true;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.ReadOnly = true;
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
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "Room";
            this.RoomColumn.Name = "RoomColumn";
            this.RoomColumn.ReadOnly = true;
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            this.UnitsColumn.ReadOnly = true;
            // 
            // IdNumberTextBox
            // 
            this.IdNumberTextBox.Location = new System.Drawing.Point(200, 50);
            this.IdNumberTextBox.Name = "IdNumberTextBox";
            this.IdNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdNumberTextBox.TabIndex = 6;
            this.IdNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNumberTextBox_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(200, 92);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.ReadOnly = true;
            this.NameLabel.Size = new System.Drawing.Size(100, 20);
            this.NameLabel.TabIndex = 7;
            // 
            // CourseLabel
            // 
            this.CourseLabel.Location = new System.Drawing.Point(200, 132);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.ReadOnly = true;
            this.CourseLabel.Size = new System.Drawing.Size(100, 20);
            this.CourseLabel.TabIndex = 8;
            // 
            // EdpCodeTextBox
            // 
            this.EdpCodeTextBox.Location = new System.Drawing.Point(200, 180);
            this.EdpCodeTextBox.Name = "EdpCodeTextBox";
            this.EdpCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EdpCodeTextBox.TabIndex = 9;
            this.EdpCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdpCodeTextBox_KeyPress);
            // 
            // YearLabel
            // 
            this.YearLabel.Location = new System.Drawing.Point(414, 128);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.ReadOnly = true;
            this.YearLabel.Size = new System.Drawing.Size(100, 20);
            this.YearLabel.TabIndex = 10;
            // 
            // TotalUnitsLabel
            // 
            this.TotalUnitsLabel.Location = new System.Drawing.Point(569, 416);
            this.TotalUnitsLabel.Name = "TotalUnitsLabel";
            this.TotalUnitsLabel.ReadOnly = true;
            this.TotalUnitsLabel.Size = new System.Drawing.Size(100, 20);
            this.TotalUnitsLabel.TabIndex = 11;
            // 
            // ulabel
            // 
            this.ulabel.AutoSize = true;
            this.ulabel.Location = new System.Drawing.Point(505, 423);
            this.ulabel.Name = "ulabel";
            this.ulabel.Size = new System.Drawing.Size(58, 13);
            this.ulabel.TabIndex = 12;
            this.ulabel.Text = "Total Units";
            // 
            // DateEnrollDateTimePicker
            // 
            this.DateEnrollDateTimePicker.Location = new System.Drawing.Point(337, 457);
            this.DateEnrollDateTimePicker.Name = "DateEnrollDateTimePicker";
            this.DateEnrollDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateEnrollDateTimePicker.TabIndex = 13;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(302, 463);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 14;
            this.Date.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Encoded by";
            // 
            // EncoderTextBox
            // 
            this.EncoderTextBox.Location = new System.Drawing.Point(147, 456);
            this.EncoderTextBox.Name = "EncoderTextBox";
            this.EncoderTextBox.Size = new System.Drawing.Size(100, 20);
            this.EncoderTextBox.TabIndex = 16;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(225, 510);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(337, 510);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Enrolled",
            "Unrolled"});
            this.StatusComboBox.Location = new System.Drawing.Point(414, 179);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 20;
            // 
            // StudentEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 583);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EncoderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DateEnrollDateTimePicker);
            this.Controls.Add(this.ulabel);
            this.Controls.Add(this.TotalUnitsLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.EdpCodeTextBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdNumberTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "StudentEnrollment";
            this.Text = "StudentEnrollment";
            this.Load += new System.EventHandler(this.StudentEnrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IdNumberTextBox;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.TextBox CourseLabel;
        private System.Windows.Forms.TextBox EdpCodeTextBox;
        private System.Windows.Forms.TextBox YearLabel;
        private System.Windows.Forms.TextBox TotalUnitsLabel;
        private System.Windows.Forms.Label ulabel;
        private System.Windows.Forms.DateTimePicker DateEnrollDateTimePicker;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EncoderTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdpCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
    }
}