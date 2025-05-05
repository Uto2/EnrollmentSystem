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
    public partial class SubjectEntry : Form
    {
        public SubjectEntry()
        {
            InitializeComponent();
        }

        string connectionstring = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True;Encrypt=False";

        private void SubjectEntry_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionstring);

            string sql = "SELECT * FROM [SUBJECTFILE]";

            SqlDataAdapter thisAdapter = new SqlDataAdapter(sql, myConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

            DataSet subjectDataSet = new DataSet();
            thisAdapter.Fill(subjectDataSet, "SubjectFile");

            DataRow subjectRow = subjectDataSet.Tables["SubjectFile"].NewRow();

            //subjectRow[""]
        }

        private void RequisiteSubjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
