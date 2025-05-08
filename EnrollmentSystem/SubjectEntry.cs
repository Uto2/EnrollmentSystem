using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class SubjectEntry : Form
    {
        public SubjectEntry()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentFile;Integrated Security=True";

        private void SubjectEntry_Load(object sender, EventArgs e)
        {
            // Initialize combo boxes
            OfferingComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
            CourseCodeComboBox.SelectedIndex = -1;
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            // Validate required fields
            if (!ValidateInputs())
                return;

            // Save main subject
            if (!SaveSubject())
                return;

            // Save requisites if any
            if (PreRequisiteRadioButton.Checked || CoRequisiteRadioButton.Checked)
            {
                SaveRequisites();
            }

            MessageBox.Show("Subject and requisites saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private bool ValidateInputs()
        {
            // Check empty fields
            if (string.IsNullOrWhiteSpace(SubjectCodeTextbox.Text) ||
                string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(UnitsTextBox.Text) ||
                OfferingComboBox.SelectedIndex == -1 ||
                CategoryComboBox.SelectedIndex == -1 ||
                CourseCodeComboBox.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(CurriculumYearTextBox.Text))
            {
                MessageBox.Show("Please fill up all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate units is numeric
            if (!int.TryParse(UnitsTextBox.Text, out int units) || units <= 0)
            {
                MessageBox.Show("Please enter valid units (positive number)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if requisite is required but not provided
            if ((PreRequisiteRadioButton.Checked || CoRequisiteRadioButton.Checked) &&
                SubjectDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one requisite subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool SaveSubject()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO SUBJECTFILE 
                                 (SFSUBJCODE, SFSUBJCOURSECODE, SFSUBJDESC, SFSUBJUNITS, 
                                  SFSUBJREGOFRNG, SFSUBJCATEGORY, SFSUBJSTATUS, SFSUBJCURRCODE)
                                 VALUES 
                                 (@code, @courseCode, @desc, @units, 
                                  @offering, @category, @status, @currCode)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@code", SubjectCodeTextbox.Text.Trim());
                        command.Parameters.AddWithValue("@courseCode", CourseCodeComboBox.Text.Trim());
                        command.Parameters.AddWithValue("@desc", DescriptionTextBox.Text.Trim());
                        command.Parameters.AddWithValue("@units", int.Parse(UnitsTextBox.Text));
                        command.Parameters.AddWithValue("@offering", OfferingComboBox.Text.Substring(0, 1));
                        command.Parameters.AddWithValue("@category", CategoryComboBox.Text.Substring(0, 1));
                        command.Parameters.AddWithValue("@status", "AC");
                        command.Parameters.AddWithValue("@currCode", CurriculumYearTextBox.Text.Trim());

                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Primary key violation
                {
                    MessageBox.Show("Subject code already exists for this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        private void SaveRequisites()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete existing requisites first to avoid duplicates
                    string deleteSql = "DELETE FROM SUBJECTPREQFILE WHERE SUBJCODE = @subjectCode";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteSql, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@subjectCode", SubjectCodeTextbox.Text.Trim());
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Insert new requisites
                    string insertSql = @"INSERT INTO SUBJECTPREQFILE 
                                       (SUBJCODE, SUBJPRECODE, SUBJCATEGORY)
                                       VALUES (@subjectCode, @preCode, @category)";

                    foreach (DataGridViewRow row in SubjectDataGridView.Rows)
                    {
                        if (row.Cells[0].Value != null) // Check if subject code exists
                        {
                            using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@subjectCode", SubjectCodeTextbox.Text.Trim());
                                insertCommand.Parameters.AddWithValue("@preCode", row.Cells[0].Value.ToString());
                                insertCommand.Parameters.AddWithValue("@category",
                                    (PreRequisiteRadioButton.Checked) ? "P" : "C"); // P for Pre, C for Co
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error saving requisites: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequisiteSubjectTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(RequisiteSubjectTextBox.Text))
                {
                    MessageBox.Show("Please enter a subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if radio button is selected
                if (!PreRequisiteRadioButton.Checked && !CoRequisiteRadioButton.Checked)
                {
                    MessageBox.Show("Please select whether this is a Pre-requisite or Co-requisite",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check for duplicate requisite
                foreach (DataGridViewRow row in SubjectDataGridView.Rows)
                {
                    if (row.Cells[0].Value?.ToString().ToUpper() == RequisiteSubjectTextBox.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("This subject is already added as a requisite",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Check if subject exists
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = "SELECT SFSUBJCODE, SFSUBJDESC, SFSUBJUNITS FROM SUBJECTFILE WHERE SFSUBJCODE = @code";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@code", RequisiteSubjectTextBox.Text.Trim());
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int index = SubjectDataGridView.Rows.Add();
                                    SubjectDataGridView.Rows[index].Cells[0].Value = reader["SFSUBJCODE"].ToString();
                                    SubjectDataGridView.Rows[index].Cells[1].Value = reader["SFSUBJDESC"].ToString();
                                    SubjectDataGridView.Rows[index].Cells[2].Value = reader["SFSUBJUNITS"].ToString();
                                    SubjectDataGridView.Rows[index].Cells[3].Value =
                                        (PreRequisiteRadioButton.Checked) ? "Pre-Requisite" : "Co-Requisite";
                                }
                                else
                                {
                                    MessageBox.Show("Subject code not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RequisiteSubjectTextBox.Clear();
            }
        }

        private void ClearInputs()
        {
            SubjectCodeTextbox.Clear();
            DescriptionTextBox.Clear();
            UnitsTextBox.Clear();
            CurriculumYearTextBox.Clear();
            RequisiteSubjectTextBox.Clear();

            OfferingComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
            CourseCodeComboBox.SelectedIndex = -1;

            PreRequisiteRadioButton.Checked = false;
            CoRequisiteRadioButton.Checked = false;

            SubjectDataGridView.Rows.Clear();
            SubjectCodeTextbox.Focus();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}