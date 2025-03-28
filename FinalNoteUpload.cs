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
    public partial class FinalNoteUpload : UserControl
    {
        public FinalNoteUpload()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            FinalUpload parentControl = this.Parent as FinalUpload;
            if (parentControl == null)
            {
                Control current = this.Parent;
                while (current != null && !(current is FinalUpload))
                {
                    current = current.Parent;
                }
                parentControl = current as FinalUpload;
            }

            if (parentControl != null && parentControl.AnnouncementChecked)
            {
                string noteTitle = parentControl.NoteTitle;
                string userName = "user";

                string announcement = $"A note in \"{noteTitle}\" is posted by {userName}";
                parentControl.AddAnnouncement(announcement);
                MessageBox.Show("Note is uploaded");

                // Clear input fields after upload
                parentControl.ClearInputFields();
                ClearInputFields();
            }

            // Update the FinalAnnouncement control in Form2
            Form2 mainForm = parentControl?.FindForm() as Form2;
            if (mainForm != null)
            {
                mainForm.UpdateFinalAnnouncement(parentControl.Announcements);
            }
        }

        private void ClearInputFields()
        {
            // Assuming there's another text box in FinalNoteUpload that needs clearing
            // textBoxInFinalNoteUpload.Clear();
        }

        private void FinalNoteUpload_Load(object sender, EventArgs e)
        {

        }
    }
}