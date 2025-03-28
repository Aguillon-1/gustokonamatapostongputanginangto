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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            this.Click += UserControl3_Click;
            AttachClickEventToChildControls(this);
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
        }

        public void days(int numday)
        {
            dailys.Text = numday + "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void UserControl3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UserControl clicked!");
        }

        private void AttachClickEventToChildControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UserControl3_Click;
                if (control.HasChildren)
                {
                    AttachClickEventToChildControls(control);
                }
            }
        }
    }
}