using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EnrollmentSystem
{
    public partial class StudentEnrollment : Form
    {
        public StudentEnrollment()
        {
            InitializeComponent();
        }

        string connectionsString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentFile;Integrated Security=True";

        private void StudentEnrollment_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection thisConnection = new SqlConnection(connectionsString))
            {
                string sql = "SELECT * FROM EnrollmentHeaderFile";
                SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();

                thisAdapter.Fill(thisDataSet, "EnrollmentHeaderFile");
                DataRow thisRow = thisDataSet.Tables["EnrollmentHeaderFile"].NewRow();
                thisRow["ENRHFSTUDID"] = IdNumberTextBox.Text;
                thisRow["ENRHFSTUDSCHLYR"] = YearLabel.Text;
                thisRow["ENRHFSTUDENCODER"] = EncoderTextBox.Text;
                thisRow["ENRHFSTUDDATEENROLL"] = DateEnrollDateTimePicker.Value;
                thisRow["ENRHFSTUDSTATUS"] = StatusComboBox.Text;

                thisDataSet.Tables["EnrollmentHeaderFile"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "EnrollmentHeaderFile");
                MessageBox.Show("Recorded");
            }
        }

        private void EdpCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    using (SqlConnection thisConnection = new SqlConnection(connectionsString))
                    {
                        thisConnection.Open();
                        using (SqlCommand thisCommand = thisConnection.CreateCommand())
                        {
                            string sql = "SELECT * FROM SubjectSchedFile WHERE SSFEDPCODE = @edpCode";
                            thisCommand.CommandText = sql;
                            thisCommand.Parameters.AddWithValue("@edpCode", EdpCodeTextBox.Text.Trim().ToUpper());


                            using (SqlDataReader ThisDataReader = thisCommand.ExecuteReader())
                            {
                                bool found = false;
                                string totalUnits = "";

                                dataGridView1.Rows.Clear();

                                while (ThisDataReader.Read())
                                {
                                    found = true;
                                    string EdpCodeColumn = ThisDataReader["SSFSUBJCODE"].ToString();
                                    string SubjectCodeColumn = ThisDataReader["SSFEDPCODE"].ToString();
                                    string StartTimeColumn = ThisDataReader["SSFSTARTTIME"].ToString();
                                    string EndTimeColumn = ThisDataReader["SSFENDTIME"].ToString();
                                    string DaysColumn = ThisDataReader["SSFDAYS"].ToString();
                                    string RoomColumn = ThisDataReader["SSFROOM"].ToString();

                                    int index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = EdpCodeColumn;
                                    dataGridView1.Rows[index].Cells[1].Value = SubjectCodeColumn;
                                    dataGridView1.Rows[index].Cells[2].Value = StartTimeColumn;
                                    dataGridView1.Rows[index].Cells[3].Value = EndTimeColumn;
                                    dataGridView1.Rows[index].Cells[4].Value = DaysColumn;
                                    dataGridView1.Rows[index].Cells[5].Value = RoomColumn;

                                }
                                if (found)
                                {
                                    TotalUnitsLabel.Text = totalUnits.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("EdpCode Not Found");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void IdNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection thisConnection = new SqlConnection(connectionsString))
                {
                    thisConnection.Open();
                    using (SqlCommand thisCommand = thisConnection.CreateCommand())
                    {
                        string sql = "SELECT * FROM StudentFile WHERE STFSTUDID = @studentId";
                        thisCommand.CommandText = sql;
                        thisCommand.Parameters.AddWithValue("@studentId", IdNumberTextBox.Text.Trim().ToUpper());


                        using (SqlDataReader ThisDataReader = thisCommand.ExecuteReader())
                        {
                            if (ThisDataReader.Read())
                            {
                                string studentName = ThisDataReader["STFSTUDFNAME"].ToString() + " " +
                                                     ThisDataReader["STFSTUDMNAME"].ToString() + " " +
                                                     ThisDataReader["STFSTUDLNAME"].ToString();
                                string course = ThisDataReader["STFSTUDCOURSE"].ToString();
                                string yearLevel = ThisDataReader["STFSTUDYEAR"].ToString();

                                NameLabel.Text = studentName;
                                CourseLabel.Text = course;
                                YearLabel.Text = yearLevel;
                            }
                            else
                            {
                                MessageBox.Show("Student ID Not Found");
                            }
                        }
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
