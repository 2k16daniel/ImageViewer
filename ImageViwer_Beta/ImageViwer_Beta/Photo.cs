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
        Image OriginalImage;
        public Photo()
        {
            InitializeComponent();
            //this.pictureBox1.MouseWheel += pictureBox1_MouseWheel;
        }
                
        public Image imagebox
        {
            set
            {
                this.pictureBox1.Image = value;
                this.pictureBox1.Size = value.Size;
            }

        }
        Image zoom(Image img, Image size)
        {
            Bitmap bmp = new Bitmap(img , img.Width + (img.Width*size.Width/100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(img);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return img;
        }

        private void Photo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {

            }
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    //set minimum size to zoom
                    if (pictureBox1.Width < 50)
                        // lbl_Zoom.Text = pictureBox1.Image.Size; 
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (pictureBox1.Width > 5000)
                        return;
                }
                pictureBox1.Width += Convert.ToInt32(pictureBox1.Width * e.Delta / 5000);
                pictureBox1.Height += Convert.ToInt32(pictureBox1.Height * e.Delta / 5000);
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
       

        private void Picture_Panel_Scroll(object sender, ScrollEventArgs e)
        {

        }   
    }
}
