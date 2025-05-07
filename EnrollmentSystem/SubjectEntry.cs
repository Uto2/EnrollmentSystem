using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class SubjectEntry : Form
    {
        public SubjectEntry()
        {
            InitializeComponent();
        }

        string connectionsString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentFile;Integrated Security=True";

        private void SubjectEntry_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection thisConnection = new SqlConnection(connectionsString);
            string Sql = "Select * From SUBJECTFILE";
            SqlDataAdapter thisAdapter = new SqlDataAdapter(Sql, thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();

            thisAdapter.Fill(thisDataSet, "SUBJECTFILE");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SFSUBJCODE"] = SubjectCodeTextbox.Text;
            thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
            thisRow["SFSUBJUNITS"] = UnitsTextBox.Text;
            thisRow["SFSUBJREGOFRNG"] = OfferingComboBox.Text.Substring(0, 1);
            thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 1);
            thisRow["SFSUBJSTATUS"] = "AC";
            thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
            thisRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text;

            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");
            MessageBox.Show("Recorded ");

            if (PreRequisiteRadioButton.Checked)
            {
                SqlConnection preReqConnection = new SqlConnection(connectionsString);
                string preReqOle = "Select * From SubjectPreqFile";
                SqlDataAdapter preReqAdapter = new SqlDataAdapter(preReqOle, preReqConnection);
                SqlCommandBuilder preReqBuilder = new SqlCommandBuilder(preReqAdapter);
                DataSet preReqDataSet = new DataSet();

                preReqAdapter.Fill(preReqDataSet, "SubjectPreqFile");

                DataRow preReqRow = preReqDataSet.Tables["SubjectPreqFile"].NewRow();
                preReqRow["SUBJCODE"] = SubjectCodeTextbox.Text;
                preReqRow["SUBJPRECODE"] = RequisiteSubjectTextBox.Text;
                preReqRow["SUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 1);

                preReqDataSet.Tables["SubjectPreqFile"].Rows.Add(preReqRow);
                preReqAdapter.Update(preReqDataSet, "SubjectPreqFile");
                MessageBox.Show("Pre-requisite Recorded ");
            }
        }

        private void RequisiteSubjectTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                    SqlConnection thisConnection = new SqlConnection(connectionsString);
                    thisConnection.Open();
                    SqlCommand thisCommand = thisConnection.CreateCommand();

                    string commandText = "SELECT * FROM SUBJECTFILE";
                    thisCommand.CommandText = commandText;
                    thisCommand.Parameters.AddWithValue("@subjectCode", RequisiteSubjectTextBox.Text.Trim().ToUpper());

                    SqlDataReader thisReader = thisCommand.ExecuteReader();
                    bool flag = false;

                    while (thisReader.Read())
                    {
                    flag = true;
                    string SubjectCodeColumn = thisReader["SFSUBJCODE"].ToString();
                    string DescriptionColumn = thisReader["SFSUBJDESC"].ToString();
                    string UnitsColumn = thisReader["SFSUBJUNITS"].ToString();

                    int index = SubjectDataGridView.Rows.Add();
                    SubjectDataGridView.Rows[index].Cells[0].Value = SubjectCodeColumn;
                    SubjectDataGridView.Rows[index].Cells[1].Value = DescriptionColumn;
                    SubjectDataGridView.Rows[index].Cells[2].Value = UnitsColumn;
                    }
                thisReader.Close();
                thisConnection.Close();

                if (!flag)
                {
                    MessageBox.Show("Subject Code Not Found");
                }
            }   
        }
    }
}
