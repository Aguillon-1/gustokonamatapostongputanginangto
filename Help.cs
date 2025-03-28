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
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                string filename = getFileName(file);
                FileName.Items.Add(filename);
            }
        }

        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }

        private void dropfilesPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void dropfilesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Select a file.";
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = getFileName(openFileDialog.FileName);
                FileName.Items.Add(filename);
            }
        }
    }
}
