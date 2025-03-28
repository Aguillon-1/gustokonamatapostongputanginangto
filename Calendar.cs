using System;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
            calendarControl1.DateClicked += CalendarControl1_DateClicked;
        }

        private void CalendarControl1_DateClicked(object sender, DateTime e)
        {
            CalendarAddEvent addEventForm = new CalendarAddEvent(e);
            addEventForm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void calendarControl1_Load(object sender, EventArgs e)
        {

        }
    }
}