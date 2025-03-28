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
    public partial class UploadNote : UserControl
    {
        public UploadNote()
        {
            InitializeComponent();
        }

        private void dragAndDropDownPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }

        private void dragAndDropDownPanel_DragLeave(object sender, EventArgs e)
        {

        }

        private void dragAndDropDownPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles= (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                string filename = getFileName(file);
                FileLists.Items.Add(filename);
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Select a file.";
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = getFileName(openFileDialog.FileName);
                FileLists.Items.Add(filename);
            }
        }

        private void sendTagButton_Click(object sender, EventArgs e)
        {
            Tags.Items.Add(tagsTextBox.Text);
            tagsTextBox.Text = "#";
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
