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
    public partial class RawConverter : Form
    {
        public RawConverter()
        {
            InitializeComponent();
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
                
            }
        }

        
    }
}
