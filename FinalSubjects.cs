using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class FinalSubjects : UserControl
    {
        public FinalSubjects()
        {
            InitializeComponent();
            finalSubjectNoteSearch1.Hide();
        }

        private void subjectOneButton_Click(object sender, EventArgs e)
        {
            finalSubjectNoteSearch1.BringToFront();
            finalSubjectNoteSearch1.Show();
        }
    }
}
