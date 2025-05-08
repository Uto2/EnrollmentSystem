using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class StudentEnrollment : Form
    {
        public StudentEnrollment()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentFile;Integrated Security=True";
        int totalUnits = 0;
        bool enteredStudentID = false;
        bool enteredSubjectEDP = false;

        private void StudentEnrollment_Load(object sender, EventArgs e)
        {
            // Initialize form load operations if needed
        }

        private void IdNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    thisConnection.Open();
                    using (SqlCommand thisCommand = thisConnection.CreateCommand())
                    {
                        string sql = "SELECT * FROM StudentFile WHERE STFSTUDID = @studentId";
                        thisCommand.CommandText = sql;
                        thisCommand.Parameters.AddWithValue("@studentId", IdNumberTextBox.Text.Trim());

                        using (SqlDataReader thisDataReader = thisCommand.ExecuteReader())
                        {
                            if (thisDataReader.Read())
                            {
                                string studentName = thisDataReader["STFSTUDFNAME"].ToString() + " " +
                                                   thisDataReader["STFSTUDMNAME"].ToString() + " " +
                                                   thisDataReader["STFSTUDLNAME"].ToString();
                                string course = thisDataReader["STFSTUDCOURSE"].ToString();
                                string yearLevel = thisDataReader["STFSTUDYEAR"].ToString();

                                NameLabel.Text = studentName;
                                CourseLabel.Text = course;
                                YearLabel.Text = yearLevel;

                                enteredStudentID = true;
                                MessageBox.Show("Student ID Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Student ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void EdpCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Check for duplicate EDP code
                bool uniqueEDPCode = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value?.ToString().ToUpper() == EdpCodeTextBox.Text.ToUpper())
                    {
                        uniqueEDPCode = false;
                        break;
                    }
                }

                if (!uniqueEDPCode)
                {
                    MessageBox.Show("Duplicate EDP Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool edpCodeFound = false;
                string edpCode = "";
                string subjectCode = "";
                DateTime startTime = DateTime.MinValue;
                DateTime endTime = DateTime.MinValue;
                string days = "";
                string room = "";
                string units = "";

                // Get subject schedule information
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    thisConnection.Open();
                    string sql = "SELECT SSF.*, SF.SFSUBJUNITS FROM SubjectSchedFile SSF " +
                                  "JOIN SubjectFile SF ON SSF.SSFSUBJCODE = SF.SFSUBJCODE " +
                                  "WHERE SSF.SSFEDPCODE = @edpCode";
                    using (SqlCommand thisCommand = new SqlCommand(sql, thisConnection))
                    {
                        thisCommand.Parameters.AddWithValue("@edpCode", EdpCodeTextBox.Text.Trim());

                        using (SqlDataReader thisDataReader = thisCommand.ExecuteReader())
                        {
                            if (thisDataReader.Read())
                            {
                                edpCodeFound = true;
                                edpCode = thisDataReader["SSFEDPCODE"].ToString();
                                subjectCode = thisDataReader["SSFSUBJCODE"].ToString();
                                startTime = Convert.ToDateTime(thisDataReader["SSFSTARTTIME"]);
                                endTime = Convert.ToDateTime(thisDataReader["SSFENDTIME"]);
                                days = thisDataReader["SSFDAYS"].ToString();
                                room = thisDataReader["SSFROOM"].ToString();
                                units = thisDataReader["SFSUBJUNITS"].ToString();
                            }
                        }
                    }
                }

                // Check for schedule conflict
                if (CheckConflict(days, startTime.ToShortTimeString(), endTime.ToShortTimeString(), dataGridView1))
                {
                    MessageBox.Show("There is a conflict with the existing schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (edpCodeFound)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = subjectCode;
                    dataGridView1.Rows[index].Cells[1].Value = edpCode;
                    dataGridView1.Rows[index].Cells[2].Value = startTime.ToShortTimeString();
                    dataGridView1.Rows[index].Cells[3].Value = endTime.ToShortTimeString();
                    dataGridView1.Rows[index].Cells[4].Value = days;
                    dataGridView1.Rows[index].Cells[5].Value = room;
                    dataGridView1.Rows[index].Cells[6].Value = units;

                    enteredSubjectEDP = true;
                    MessageBox.Show("Subject Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update total units
                    totalUnits += int.Parse(units);
                    TotalUnitsLabel.Text = totalUnits.ToString();
                }
                else
                {
                    MessageBox.Show("EDP Code Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                EdpCodeTextBox.Text = "";
            }
        }

        private bool CheckConflict(string newDays, string newStartTime, string newEndTime, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    string existingDays = row.Cells[4].Value.ToString();
                    string existingStartTime = row.Cells[2].Value.ToString();
                    string existingEndTime = row.Cells[3].Value.ToString();

                    // Check if any of the days in newDays are also in existingDays
                    foreach (char day in newDays)
                    {
                        if (existingDays.Contains(day))
                        {
                            // If there's a day conflict, check time overlap
                            TimeSpan newStart = DateTime.Parse(newStartTime).TimeOfDay;
                            TimeSpan newEnd = DateTime.Parse(newEndTime).TimeOfDay;
                            TimeSpan existingStart = DateTime.Parse(existingStartTime).TimeOfDay;
                            TimeSpan existingEnd = DateTime.Parse(existingEndTime).TimeOfDay;

                            if ((newStart < existingEnd && newEnd > existingStart))
                            {
                                return true; // Conflict found
                            }
                        }
                    }
                }
            }
            return false; // No conflict found
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!enteredStudentID || !enteredSubjectEDP)
            {
                MessageBox.Show("Please enter a valid Student ID and at least one subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(EncoderTextBox.Text))
            {
                MessageBox.Show("Please enter the encoder's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateEnrollDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Enrollment date cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save to EnrollmentHeaderFile
            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                thisConnection.Open();

                // First save the header
                string headerSql = @"INSERT INTO EnrollmentHeaderFile 
                                   (ENRHFSTUDID, ENRHFSTUDSCHLYR, ENRHFSTUDENCODER, ENRHFSTUDDATEENROLL, ENRHFSTUDSTATUS, ENRHFSTUDTOTALUNITS)
                                   VALUES (@studentId, @schoolYear, @encoder, @dateEnrolled, @status, @totalUnits)";

                using (SqlCommand headerCommand = new SqlCommand(headerSql, thisConnection))
                {
                    headerCommand.Parameters.AddWithValue("@studentId", IdNumberTextBox.Text);
                    headerCommand.Parameters.AddWithValue("@schoolYear", YearLabel.Text);
                    headerCommand.Parameters.AddWithValue("@encoder", EncoderTextBox.Text);
                    headerCommand.Parameters.AddWithValue("@dateEnrolled", DateEnrollDateTimePicker.Value);
                    headerCommand.Parameters.AddWithValue("@status", StatusComboBox.Text);
                    headerCommand.Parameters.AddWithValue("@totalUnits", totalUnits);

                    try
                    {
                        headerCommand.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // Primary key violation
                        {
                            MessageBox.Show("This student is already enrolled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        throw;
                    }
                }

                // Then save the details
                string detailSql = @"INSERT INTO EnrollmentDetailFile 
                                   (ENRDFSTUDID, ENRDFSTUDEDPCODE, ENRDFSTUDSUBJCDE, ENRDFSTUDSTATUS)
                                   VALUES (@studentId, @edpCode, @subjectCode, @status)";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value != null) // Check if EDP Code exists
                    {
                        using (SqlCommand detailCommand = new SqlCommand(detailSql, thisConnection))
                        {
                            detailCommand.Parameters.AddWithValue("@studentId", IdNumberTextBox.Text);
                            detailCommand.Parameters.AddWithValue("@edpCode", row.Cells[1].Value.ToString());
                            detailCommand.Parameters.AddWithValue("@subjectCode", row.Cells[0].Value.ToString());
                            detailCommand.Parameters.AddWithValue("@status", "EN"); // Enrolled
                            detailCommand.ExecuteNonQuery();
                        }
                    }
                }

                // Update student status
                string updateStudentSql = "UPDATE StudentFile SET STFSTUDSTATUS = 'AC' WHERE STFSTUDID = @studentId";
                using (SqlCommand updateCommand = new SqlCommand(updateStudentSql, thisConnection))
                {
                    updateCommand.Parameters.AddWithValue("@studentId", IdNumberTextBox.Text);
                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Enrollment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            IdNumberTextBox.Text = "";
            NameLabel.Text = "";
            CourseLabel.Text = "";
            YearLabel.Text = "";
            EdpCodeTextBox.Text = "";
            EncoderTextBox.Text = "";
            TotalUnitsLabel.Text = "0";
            StatusComboBox.SelectedIndex = -1;
            DateEnrollDateTimePicker.Value = DateTime.Now;
            dataGridView1.Rows.Clear();
            totalUnits = 0;
            enteredStudentID = false;
            enteredSubjectEDP = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}