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
    public partial class FinalAnnouncement : UserControl
    {
        public FinalAnnouncement()
        {
            InitializeComponent();
        }

        public void SetAnnouncementMessages(List<string> messages)
        {
            label1.Text = string.Join(Environment.NewLine, messages);
            // Debug statement to verify the label is being updated
            Console.WriteLine($"Announcements updated: {label1.Text}");
            label1.Refresh(); // Ensure the label is refreshed
        }

        private void FinalAnnouncement_Load(object sender, EventArgs e)
        {

        }

        private void announcementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}