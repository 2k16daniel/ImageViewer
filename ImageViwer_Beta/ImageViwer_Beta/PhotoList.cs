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
    public partial class PhotoList : Form{
    
        string[] itemList;
        List<string> imagelist = new List<string>();
        public PhotoList()
        {
            InitializeComponent();
        }

        private void ImageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PhotoList_Load(object sender, EventArgs e)
        {
            
        }
        public void ShowingArray(string[] array)
        {
            listBox1.Items.Add(array);
        }
    }
}
