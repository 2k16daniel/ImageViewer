using ImageMagick;
using MetadataExtractor;
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

        List<string> imagelist = new List<string>();
        string rawImage;
        string CameraGlobalDirectory;
        int pCurrentImage = -1;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            
        }


        public void CameraDirectorySet(string CamDir)
        {
            MessageBox.Show(CamDir);
            //var files = System.IO.Directory.EnumerateFiles(CamDir, "*.*", SearchOption.AllDirectories)
            //.Where(s => s.EndsWith(".jpg") || s.EndsWith(".JPG"));
            DirectoryInfo dinfo = new DirectoryInfo(CamDir);
            FileInfo[] Files = dinfo.GetFiles("*.jpg");
            foreach (FileInfo file in Files)
            {
                imagelist.Add(file.FullName);
                ImageListview.Items.Add(file.Name, 0);
                ImageListview.Refresh();
            } 
        }

        private void openPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageListview.Clear();
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "JPEG|*.jpg;*.JPEG|Bitmaps|*.bmp;*.BMP|PNG|*.png;*.PNG|GIF|*.gif;*.GIF|TIFF|*.tiff;*.TIFF";
            open.Multiselect = true;
            open.ValidateNames = true;
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ImageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImageListview_ItemActivate(object sender, EventArgs e)
        {
            if (ImageListview.FocusedItem != null)
            {
                
                try
                {
                    Image img = Image.FromFile(imagelist[ImageListview.FocusedItem.Index]);
                    photobox = img;
                    FileNameLabel.Text = Path.GetFileName(imagelist[ImageListview.FocusedItem.Index]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Invalid File! Please Make sure to choose the valid file!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }

            }
        }
        private void Main_Picturebox_Click(object sender, EventArgs e)
        {

            if (ImageListview.FocusedItem != null)
            {

            }
        }
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
                        // lbl_Zoom.Text = pictureBox1.Image.Size; 
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (MainPictureBox.Width > 5000)
                        return;
                }
                MainPictureBox.Width += Convert.ToInt32(MainPictureBox.Width * e.Delta / 5000);
                MainPictureBox.Height += Convert.ToInt32(MainPictureBox.Height * e.Delta / 5000);
            }
        }

        
        private void imageMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] infoImage = new string[40];
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
            catch (NullReferenceException)
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
            } 
        }

        private void viewFullsizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Photo phto = new Photo();
                if (ImageListview.FocusedItem != null)
                {

                    Image img = Image.FromFile(imagelist[ImageListview.FocusedItem.Index]);
                    phto.imagebox = img;
                    phto.ShowDialog();


                }
                else
                {

                    Image img = Image.FromFile(rawImage);
                    phto.imagebox = img;
                    phto.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Invalid File! Please Make sure to choose the valid file!",
                MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        

        protected void ShowCurrentImage()
        {
           
            if (pCurrentImage >= 0 && pCurrentImage <= imagelist.Count() - 1)
            {
                //ctureBox1.Image = Bitmap.FromFile(pFileNames[pCurrentImage]);
                Image img = Image.FromFile(imagelist[pCurrentImage]);
                photobox = img;
                FileNameLabel.Text = Path.GetFileName(imagelist[pCurrentImage]);
                
            }
        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            if (imagelist.Count() > 0)
            {
                pCurrentImage = pCurrentImage == 0 ? imagelist.Count() - 1 : --pCurrentImage;
                ShowCurrentImage();
            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (imagelist.Count() > 0)
            {
                pCurrentImage = pCurrentImage == imagelist.Count() - 1 ? 0 : ++pCurrentImage;
                ShowCurrentImage();
            }
        }

        private void rawConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RawConverter rawform = new RawConverter()) {
                rawform.ShowDialog();
            }
        }

        private void openRawPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageListview.Clear();
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "CANON|*.cr2;*.crw|NIKON|*.ORF|FUJI|*.raf|GIF|*.gif|TIFF|*.tiff";

            open.Multiselect = false;
            open.ValidateNames = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                rawImage = open.FileName;
                try
                {
                    using (MagickImage image = new MagickImage(rawImage))
                    {
                        var oldfn = Path.GetFileName(rawImage);
                        var newfn = Path.ChangeExtension(oldfn, ".jpg");
                        image.Write(newfn);
                        Image img = Image.FromFile(newfn);
                        photobox = img;
                        label1.Text = oldfn;
                    }
                }
                catch (MagickCoderErrorException errorCodec)
                {
                    //MessageBox.Show("Invalid File! or the file is Currupted.");
                    MessageBox.Show(this, errorCodec.Message, "Invalid File! or the file is Currupted.",
                MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                }
            }
        }

        private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraForm camForm = new CameraForm();
            camForm.ShowDialog();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            ImageListview.Refresh();
        }
        }
    }
