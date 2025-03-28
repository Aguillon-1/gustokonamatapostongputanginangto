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
    public partial class AdminFinalCreateClass : Form
    {
        public AdminFinalCreateClass()
        {
            InitializeComponent();
            singleFramePanel.Show();
            doubleFramePanel.Hide();
        }

        bool expandForm = true;

        private void formExpand_Tick(object sender, EventArgs e)
        {
            if (expandForm == true)
            {
                this.Width += 50;
                if (this.Width >= this.MaximumSize.Width)
                {

                    formExpand.Stop();

                    expandForm = false;
                }
            }

            else
            {
                this.Width -= 50;
                if (this.Width <= this.MinimumSize.Width)
                {

                    formExpand.Stop();
                    expandForm = true;
                }
            }
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            addSubjectButton.Hide();
            formExpand.Start();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 400;
            this.Top = 150;
            singleFramePanel.Hide();
            doubleFramePanel.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void createClassButton_Click(object sender, EventArgs e)
        {

        }

        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Select a file.";
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = getFileName(openFileDialog.FileName);
                FileNameLists.Items.Add(filename);
            }
        }

        private void singleFramePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
