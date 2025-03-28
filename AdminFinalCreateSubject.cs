using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class AdminFinalCreateSubject : Form
    {
        private List<CreateSubject> subjects = new List<CreateSubject>();

        public AdminFinalCreateSubject()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void createSubject1_Load(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            // Logic for when the Done button is clicked
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            // Assuming you have a CreateSubject UserControl named createSubject1
            string subjectName = createSubject1.SubjectName;
            string professorName = createSubject1.ProfessorName;

            // Add the subject to the list
            subjects.Add(createSubject1);

            // Assuming you have a SubjectList UserControl to display the subjects
            subjectList1.AddSubject(subjectName, professorName);
        }

        private void panelDesign1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}