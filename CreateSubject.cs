namespace Classroom_Management_System
{
    public partial class CreateSubject : UserControl
    {
        public CreateSubject()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateSubject_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string SubjectName
        {
            get { return subjectNameTextBox.Text; }
        }

        public string ProfessorName
        {
            get { return professorNameTextBox.Text; }
        }
    }
}