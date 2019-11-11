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

namespace ImageViwer_Beta
{
    public partial class RawConverter : Form
    {
        List<string> rawlistvariable = new List<string>();
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
            open.Filter = "CANON|*.crw|NIKON|*.ORF|FUJI|*.raf|GIF|*.gif|TIFF|*.tiff";

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

        
        
    }
}
