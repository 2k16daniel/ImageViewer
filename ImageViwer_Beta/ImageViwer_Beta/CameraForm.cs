using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViwer_Beta
{
    public partial class CameraForm : Form
    {
        Form1 menuForm = new Form1();
        string CameraDir;
        public CameraForm()
        {
            InitializeComponent();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderPicker = new FolderBrowserDialog();
            // Show the FolderBrowserDialog.
            DialogResult result = folderPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                CameraDir = folderPicker.SelectedPath;
                BrowseCameraDirectory.Text = CameraDir;
            }
            
        }
        private void set_btn_Click(object sender, EventArgs e)
        {
            ImageViwer_Beta.Form1.Globals.CameraGlobalDirectory = CameraDir;
        }
    }
}
