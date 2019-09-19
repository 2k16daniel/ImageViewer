﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViwer_Beta
{
    public partial class Form1 : Form
    {
        List<string> imagelist = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void Button_PicOpen_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagelist.Clear();
                ImageListview.Items.Clear();
                foreach (string filename in open.FileNames)
                {
                    FileInfo imginfo = new FileInfo(filename);
                    imagelist.Add(imginfo.FullName);
                    ImageListview.Items.Add(imginfo.Name, 0);
                }
                
            }  


            //open.Dispose();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImageListview.FocusedItem != null)
            {
                using (Photo phto = new Photo())
                {
                    Image img = Image.FromFile(imagelist[ImageListview.FocusedItem.Index]);


                }
            }
        }

        /* Usless code , save this for reference!!
        
         * private void PictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureBox Picture = new PictureBox();
                Picture.ImageLocation = open.FileName;
                
            }
        } */
        
    }
}
