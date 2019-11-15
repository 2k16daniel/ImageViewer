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
using System.Threading;

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
            open.Filter = "CANON|*.cr2;*.crw|NIKON|*.ORF|FUJI|*.raf|GIF|*.gif|TIFF|*.tiff";

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

        private async void convert_btn_Click(object sender, EventArgs e)
        {
            /* Pag gagayahan pra sa progress bar
             * private async void button1_Click(object sender, EventArgs e)
            {
                Stopwatch timer = new Stopwatch();
                var openFileDialog1 = new OpenFileDialog();
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 30;  
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {      
                    timer.Start();
                    textBox1.Text = await Task.Run(() => 
                        GetFileMD5Hash(openFileDialog1.FileName));
                    timer.Stop();
                    lblTime.Text = timer.Elapsed.ToString();
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.Increment(100);
                }
                progressBar1.MarqueeAnimationSpeed = 0;
            } 
             */
            foreach (string imageinraw in rawlistvariable)
            {
                using (MagickImage image = new MagickImage(imageinraw))
                {
                    var oldfn = Path.GetFileName(imageinraw);
                    var newfn = Path.ChangeExtension(oldfn, convert_combo.Text);
                    var combine = Path.Combine(savePath, newfn);
                    image.Write(combine);
                }
            }
             
            //FileLoading.Close();
        }

        private void RawList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if(progressBar1.Value > 99){
                RawConverter rawloading = new RawConverter();
                rawloading.Show();
                this.Hide();
                timer.Enabled = false;
            }
        }

        
    }
}
