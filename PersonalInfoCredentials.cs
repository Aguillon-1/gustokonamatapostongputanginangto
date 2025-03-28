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

    public partial class personalInfoPanel : UserControl
    {
        
        public personalInfoPanel()
        {
            InitializeComponent();
        }


        public TextBox FirstNameTextBox => firstnameTextBox;
        public TextBox MiddleNameTextBox => middleNameTextBox;
        public TextBox LastNameTextBox => lastnameTextBox;
        public TextBox EmailAddressTextBox => emailAddressTextBox;
        public DateTimePicker BirthdayInput => birthdayInput;
        public TextBox AddressNoTextBox => addressNoTextBox;
        public TextBox StreetNameTextBox => streetNameTextBox;
        public TextBox BarangayTextBox => barangayTextBox;
        public TextBox CityTextBox => cityTextBox;

        private void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdayInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addressNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void streetNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void barangayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
