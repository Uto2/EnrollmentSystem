using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class StudentEntry : Form
    {
        public StudentEntry()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionsString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentFile;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectionsString);
            string sql = "SELECT * FROM STUDENTFILE";
            SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, myConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "StudentFile");
            try
            {
                if
                (IdTextBox.Text.Equals("") ||
                LastnameTextBox.Text.Equals("") ||
                FirstNameTextBox.Text.Equals("") ||
                MiddleInitailTextBox.Text.Equals("") ||
                LastnameTextBox.Text.Equals("") ||
                CourseTextBox.Text.Equals("") ||
                YearTextBox.Text.Equals("") ||
                RemarksTextBox.Text.Equals("") ||
                StatusTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill up");
                }
                else
                {
                    DataRow thisRow = thisDataSet.Tables["StudentFile"].NewRow();
                    thisRow["STFSTUDID"] = Convert.ToInt64(IdTextBox.Text);
                    thisRow["STFSTUDLNAME"] = LastnameTextBox.Text;
                    thisRow["STFSTUDFNAME"] = FirstNameTextBox.Text;
                    thisRow["STFSTUDMNAME"] = MiddleInitailTextBox.Text;
                    thisRow["STFSTUDCOURSE"] = CourseTextBox.Text;
                    thisRow["STFSTUDYEAR"] = YearTextBox.Text;
                    thisRow["STFSTUDREMARKS"] = RemarksTextBox.Text;
                    thisRow["STFSTUDMNAME"] = MiddleInitailTextBox.Text;
                    thisRow["STFSTUDSTATUS"] = StatusTextBox.Text;

                    thisDataSet.Tables["StudentFile"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "StudentFile");
                    MessageBox.Show("Entries Recorded");
                }
            }
            catch (Exception ex) { }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}