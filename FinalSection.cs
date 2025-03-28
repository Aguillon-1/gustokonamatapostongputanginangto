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
    public partial class FinalSection : UserControl
    {
        public FinalSection()
        {
            InitializeComponent();
            editPanel.Hide();
            nameSearchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nameSearchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            

        }
        private void classOfficersEditButton_Click(object sender, EventArgs e)
        {
            editPanel.BringToFront();
            editPanel.Show();
            makeMemberButton.BringToFront();
            editPositionLabel.Text = "Class Officer";
        }
        private void classMembersEditButton_Click(object sender, EventArgs e)
        {
            editPanel.BringToFront();
            editPanel.Show();
            makeOfficerButton.BringToFront();
            editPositionLabel.Text = "Class Member";
        }

        private void exitEditButton_Click(object sender, EventArgs e)
        {
            editPanel.Hide();
        }
        private void kickButton_Click(object sender, EventArgs e)
        {

        }





}
}
