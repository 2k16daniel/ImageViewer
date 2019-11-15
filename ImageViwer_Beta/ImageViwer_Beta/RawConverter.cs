using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

namespace ImageViwer_Beta
{
    public partial class RawConverter : Form
    {
        List<string> rawlistvariable = new List<string>();
        string savePath;
        int pCurrentImage = -1;
        public RawConverter()
        {
            InitializeComponent();
            //this.comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.convert_combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void openRaw_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "CANON|*.cr2|NIKON|*.ORF|FUJI|*.raf|GIF|*.gif|TIFF|*.tiff";

            open.Multiselect = true;
            open.ValidateNames = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in open.FileNames)
                {
                    //FileInfo imginfo = new FileInfo(filename);
                    FileInfo rawinfo = new FileInfo(filename);
                    //imagelist.Add(imginfo.FullName);
                    //ImageListview.Items.Add(imginfo.Name, 0);
                    rawlistvariable.Add(rawinfo.FullName);
                    RawList.Items.Add(rawinfo.Name);
                }
            }
        }

        private void RawConverter_Load(object sender, EventArgs e)
        {

        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = folderBrowserDialog1.SelectedPath;
                SaveFileLocation.Text = savePath;
            }
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            foreach (string imageinraw in rawlistvariable)
            {
                using (MagickImage image = new MagickImage(imageinraw))
                {
                    image.Write("StillLife.jpg");
                }
            }
        }

        private void RawList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
