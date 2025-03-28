using System;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class SubjectList : UserControl
    {
        public SubjectList()
        {
            InitializeComponent();
        }

        public void AddSubject(string subjectName, string professorName)
        {
            ListViewItem item = new ListViewItem(subjectName);
            item.SubItems.Add(professorName);
            listView1.Items.Add(item);
        }
    }
}