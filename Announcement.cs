using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Classroom_Management_System
{
    public partial class Announcement : UserControl
    {
        public Announcement()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public extern static bool MessageBeep(uint type);


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Announcement_Load(object sender, EventArgs e)
        {

        }

        private void userAnnouncementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example announcement!");
            notifyUser("New Announcement", "You have a new announcement. Please check it!");
        }

        private void notifyUser(string title, string message)
        {
            MessageBox.Show(message, title);
            MessageBeep(0);
        }



    }
}
