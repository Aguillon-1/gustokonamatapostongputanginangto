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
    public partial class FinalSubjectNoteSearch : UserControl
    {
        public FinalSubjectNoteSearch()
        {
            InitializeComponent();
            finalSubjectNoteView1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void searchResultFormat1_Load(object sender, EventArgs e)
        {
            finalSubjectNoteView1.BringToFront();
        }

        private void searchResultFormat1_Click(object sender, EventArgs e)
        {
            finalSubjectNoteView1.BringToFront();
            finalSubjectNoteView1.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
