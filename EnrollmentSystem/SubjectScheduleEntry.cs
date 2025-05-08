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

namespace EnrollmentSystem
{
    public partial class SubjectScheduleEntry : Form
    {
        public SubjectScheduleEntry()
        {
            InitializeComponent();
        }

        string connectionsString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentFile;Integrated Security=True";

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection thisConnection = new SqlConnection(connectionsString))
            {
                if (EdpCodeTextBox.Text.Equals("") ||
                    SubjectCodeTextBox.Text.Equals("") ||
                    TimeStartTextBox.Text.Equals("") ||
                    TimeEndTextBox.Text.Equals("") ||
                    DaysTextBox.Text.Equals("") ||
                    SectionTextBox.Text.Equals("") ||
                    RoomTextBox.Text.Equals("") ||
                    SchoolYearTextBox.Text.Equals("") ||
                    AMPMComboBox.Text.Equals(""))
                {
                    MessageBox.Show("Please fill up all required fields");
                    return;
                }

                string Ole = "Select * From SubjectSchedFile";
                SqlDataAdapter thisAdapter = new SqlDataAdapter(Ole, thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();

                thisAdapter.Fill(thisDataSet, "SubjectSchedFile");
                DataRow thisRow = thisDataSet.Tables["SubjectSchedFile"].NewRow();
                thisRow["SSFEDPCODE"] = EdpCodeTextBox.Text;
                thisRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text;
                thisRow["SSFSTARTTIME"] = TimeStartTextBox.Text;
                thisRow["SSFENDTIME"] = TimeEndTextBox.Text;
                thisRow["SSFDAYS"] = DaysTextBox.Text;
                thisRow["SSFSECTION"] = SectionTextBox.Text;
                thisRow["SSFROOM"] = RoomTextBox.Text;
                thisRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text;
                thisRow["SSFXM"] = AMPMComboBox.Text;
                thisRow["SSFMAXSIZE"] = Convert.ToInt16(30);
                thisRow["SSFCLASSSIZE"] = Convert.ToInt16(0);

                thisDataSet.Tables["SubjectSchedFile"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "SubjectSchedFile");
                MessageBox.Show("Recorded");
            }
        }

        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection thisConnection = new SqlConnection(connectionsString))
                {
                    thisConnection.Open();
                    string sql = "SELECT SFSUBJDESC FROM SUBJECTFILE WHERE SFSUBJCODE = @subjCode";

                    using (SqlCommand thisCommand = new SqlCommand(sql, thisConnection))
                    {
                        thisCommand.Parameters.AddWithValue("@subjCode", SubjectCodeTextBox.Text.Trim());

                        object result = thisCommand.ExecuteScalar();
                        if (result != null)
                        {
                            DescriptionLabel.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Subject Code Not Found");
                        }
                    }
                }
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                SqlConnection thisConnection = new SqlConnection(connectionsString);
                thisConnection.Open();
                SqlCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = sql;

                SqlDataReader thisDataReader = thisCommand.ExecuteReader();
                bool found = false;
                string subjectCode = "";
                string description = "";

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == SubjectCodeTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectCode = thisDataReader["SFSUBJCODE"].ToString();
                        description = thisDataReader["SFSUBJDESC"].ToString();

                        break;

                    }

                }
                if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                {
                    SubjectCodeTextBox.Text = subjectCode;
                    DescriptionLabel.Text = description;

                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EdpCodeTextBox.Clear();
            SubjectCodeTextBox.Clear();
            TimeStartTextBox.Clear();
            TimeEndTextBox.Clear();
            DaysTextBox.Clear();
            SectionTextBox.Clear();
            RoomTextBox.Clear();
            SchoolYearTextBox.Clear();

            AMPMComboBox.SelectedIndex = -1;

            DescriptionLabel.Text = "";

            EdpCodeTextBox.Focus();
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