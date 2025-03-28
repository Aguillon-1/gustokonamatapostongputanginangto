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
    public partial class AdmitCreateForm : Form
    {
        public AdmitCreateForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Select a file.";
                openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*";

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK) 
                {
                    foreach (String file in openFileDialog.FileNames)
                    {
                        try
                        {
                            Bitmap myBitmap = new Bitmap(file);
                            previewPanel.BackgroundImage = myBitmap;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = getFileName(openFileDialog.FileName);
                FileName.Items.Add(filename);
            }
        }

        private void dragAndDropDownFilesPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                string filename = getFileName(file);
                FileName.Items.Add(filename);
                Bitmap myBitmap = new Bitmap(file);
                previewPanel.BackgroundImage = myBitmap;
            }
        }

        private void dragAndDropDownFilesPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
