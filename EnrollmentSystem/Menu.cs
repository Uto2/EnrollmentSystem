using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
            
        private void StudentEntryButton_Click_1(object sender, EventArgs e)
        {
            StudentEntry StudentEntry = new
            StudentEntry();
            StudentEntry.Show();
            this.Hide();
        }

        private void ScheduleEntry_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntry subjectScheduleEntry = new
            SubjectScheduleEntry();
            subjectScheduleEntry.Show();
            this.Hide();
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            SubjectEntry subjectEntry = new
            SubjectEntry();
            subjectEntry.Show();
            this.Hide();    
        }
    }
}
