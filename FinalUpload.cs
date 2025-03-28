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
    public partial class FinalUpload : UserControl
    {
        public FinalUpload()
        {
            InitializeComponent();
            finalNoteUpload1.Hide();
            Announcements = new List<string>();
        }

        public bool AnnouncementChecked { get; private set; }
        public string NoteTitle { get; private set; }
        public List<string> Announcements { get; private set; }

        private void saveButton_Click(object sender, EventArgs e)
        {
            finalNoteUpload1.BringToFront();
            finalNoteUpload1.Show();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
            }
        }

        private void previewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void announcementCheckedBox_CheckedChanged_1(object sender, EventArgs e)
        {
            AnnouncementChecked = announcementCheckedBox.Checked;
        }

        private void titleTextBox_TextChanged_1(object sender, EventArgs e)
        {
            NoteTitle = titleTextBox.Text;
        }

        public void AddAnnouncement(string announcement)
        {
            Announcements.Add(announcement);
        }

        public void ClearInputFields()
        {
            titleTextBox.Clear();
            descTextBox.Clear(); // Assuming there's a description textbox
        }

        private void descTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileDropPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}