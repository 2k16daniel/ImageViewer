using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
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
        protected string[] pFileNames;
        protected int pCurrentImage = -1;
        List<string> imagelist = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        
        private void Button_PicOpen_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png *.tiff)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.tiff";
            //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            open.Multiselect = true;
            open.ValidateNames = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagelist.Clear();
                //ImageListview.Items.Clear();
                foreach (string filename in open.FileNames)
                {
                    FileInfo imginfo = new FileInfo(filename);
                    imagelist.Add(imginfo.FullName);
                   // ImageListview.Items.Add(imginfo.Name, 0);
                }
            }
            //open.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hello
        }

        private void ImageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImageListview_ItemActivate(object sender, EventArgs e)
        {
           /* if (ImageListview.FocusedItem != null)
            {
              
                try
                {
                    Image img = Image.FromFile(imagelist[ImageListview.FocusedItem.Index]);
                    photobox = img;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(this, ex.Message, "Invalid File! Please Make sure to choose the valid file!",
                    //MessageBoxButtons.OK, MessageBoxIcon.Information
                    MessageBox.Show("Invalid File! Please Make sure to choose the valid file!");
                    
                }

            } */
        } 
         /* private void Main_Picturebox_Click(object sender, EventArgs e)
        {

            if (ImageListview.FocusedItem != null)
            {

            }
        }
          */
        public Image photobox
        {
            set
            {
                //this.MainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.MainPictureBox.Image = value;
                //this.MainPictureBox.Size = value.Size;
            }
        }
        private void bttn_fullsize_Click(object sender, EventArgs e)
        {

            /* Usless code , save this for reference!!
            if (ImageListview.FocusedItem != null)
            {
                try
                {
                    using (Photo phto = new Photo())
                    {
                        Image img = Image.FromFile(imagelist[ImageListview.FocusedItem.Index]);
                        phto.imagebox = img;
                        phto.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid File! Please Make sure to choose the valid file!");
                }
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
           /* string[] infoImage = new string[40];
            int i = 0;
            string toDisplay = "";
            try
            {
                var directories = ImageMetadataReader.ReadMetadata(imagelist[ImageListview.FocusedItem.Index]);
                
                
                    foreach (var directory in directories)
                    {
                         
                            foreach (var tag in directory.Tags)
                            {
                               
                                infoImage[i] = tag.Name + ":  " + tag.Description;
                                toDisplay = string.Join(Environment.NewLine, infoImage);
                                i++;
                            }                       
                    }
                    MessageBox.Show(toDisplay);                              
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("select some image first! ");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(toDisplay);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(toDisplay);
            }
            catch (ImageProcessingException)
            {
                MessageBox.Show("Invalid Digital Image file!");
            } */
        }
               
        private void MainPictureBox_Click(object sender, EventArgs e)
        {

        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    //set minimum size to zoom
                    if (MainPictureBox.Width < 50)
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (MainPictureBox.Width > 10000)
                        return;
                }
                MainPictureBox.Width += Convert.ToInt32(MainPictureBox.Width * e.Delta / 10000);
                MainPictureBox.Height += Convert.ToInt32(MainPictureBox.Height * e.Delta / 10000);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openPhotoMenu_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "JPEG|*.jpg|Bitmaps|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagelist.Clear();
                //ImageListview.Items.Clear();
                foreach (string filename in openFileDialog.FileNames)
                {
                    FileInfo imginfo = new FileInfo(filename);
                    imagelist.Add(imginfo.FullName);
                      // ImageListview.Items.Add(imginfo.Name, 0);        
                    pFileNames = openFileDialog.FileNames;
                    pCurrentImage = 0;
                    ShowCurrentImage();
                }
            }
        }

        protected void ShowCurrentImage()
        {
            foreach (string image in pFileNames)
            {
                if (pCurrentImage >= 0 && pCurrentImage <= pFileNames.Length - 1)
                {

                    MainPictureBox.Image = Bitmap.FromFile(pFileNames[pCurrentImage]);

                }
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            try
            {
                    if (pFileNames.Length > 0)
                    {
                        pCurrentImage = pCurrentImage == 0 ? pFileNames.Length - 1 : --pCurrentImage;
                        ShowCurrentImage();
                    }
            }
            catch (Exception ex)
            {
            }

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pFileNames.Length > 0)
                {
                    pCurrentImage = pCurrentImage == pFileNames.Length - 1 ? 0 : ++pCurrentImage;
                    ShowCurrentImage();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void fullSizeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Photo phto = new Photo())
                {
                    //Image img = Image.FromFile(imagelist[ImageListview.FocusedItem.Index]);
                    Image img = MainPictureBox.Image;
                    phto.imagebox = img;
                    phto.ShowDialog();

                }
            }
            catch (Exception ex)
               {
                MessageBox.Show("Invalid File! Please Make sure to choose the valid file!");
            }
        }

        private void selectedImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       
        }
    }
