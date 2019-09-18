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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Button_PicOpen_Click(object sender, EventArgs e)
        {
            OpenFile_Image.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFile_Image_FileOk(object sender, CancelEventArgs e)
        {
            this.OpenFile_Image = new System.Windows.Forms.OpenFileDialog();
            
        }

        
    }
}
