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
    public partial class Photo : Form
    {
 
        public Photo()
        {
            InitializeComponent();
            this.pictureBox1.MouseWheel += pictureBox1_MouseWheel;
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                pictureBox1.Width = pictureBox1.Width + 50;
                pictureBox1.Height = pictureBox1.Height + 50;
            }
            else
            {
                pictureBox1.Width = pictureBox1.Width - 50;
                pictureBox1.Width = pictureBox1.Height - 50;
            }
        }


        Image imgoriginal;

        public Image imagebox
        {
            set
            {
                this.pictureBox1.Image = value;
                this.pictureBox1.Size = value.Size;
            }

        }

        private void Photo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {

            }
        }

        private void Photo_Load(object sender, EventArgs e)
        {
           
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Picture_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        Image Zoom(Image img, Image size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        } 

        
    }
}
