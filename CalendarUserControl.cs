using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class CalendarControl : UserControl
    {
        int month, year;
        public event EventHandler<DateTime> DateClicked;

        public CalendarControl()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            DisplayDays();
        }

        private void DisplayDays()
        {
            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            Date1.Text = $"{monthname} {year}";

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControl3 ucdays = new UserControl3();
                ucdays.days(i);
                int day = i; // Ensure the correct day value is captured
                ucdays.Click += (s, e) => OnDayClick(new DateTime(year, month, day)); // Raise event on day click
                daycontainer.Controls.Add(ucdays);
            }
        }

        protected virtual void OnDayClick(DateTime date)
        {
            DateClicked?.Invoke(this, date);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            DisplayDays();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            if (month < 1)
            {
                month = 12;
                year--;
            }

            DisplayDays();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Date1_Click(object sender, EventArgs e)
        {

        }
    }
}