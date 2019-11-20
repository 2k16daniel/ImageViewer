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
        // initialize global Variable
        Form1 menuForm = new Form1();
        List<string> CameraDir = new List<string>();
        public CameraForm()
        {
            InitializeComponent();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                CameraDir = folderBrowserDialog1.SelectedPath;
                SaveFileLocation.Text = savePath;
            }
            
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            menuForm.CameraDirectorySet(CameraDir);
        }

        
    }
}
