namespace ImageViwer_Beta
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Button_PicOpen = new System.Windows.Forms.Button();
            this.OpenFile_Image = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(31, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(845, 337);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Button_PicOpen
            // 
            this.Button_PicOpen.Location = new System.Drawing.Point(404, 343);
            this.Button_PicOpen.Name = "Button_PicOpen";
            this.Button_PicOpen.Size = new System.Drawing.Size(75, 32);
            this.Button_PicOpen.TabIndex = 1;
            this.Button_PicOpen.Text = "OPEN";
            this.Button_PicOpen.UseVisualStyleBackColor = true;
            this.Button_PicOpen.Click += new System.EventHandler(this.Button_PicOpen_Click);
            // 
            // OpenFile_Image
            // 
            this.OpenFile_Image.FileName = "openFileDialog1";
            this.OpenFile_Image.Filter = "Jpeg files (*.jpg)|";
            this.OpenFile_Image.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFile_Image_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 456);
            this.Controls.Add(this.Button_PicOpen);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Button_PicOpen;
        private System.Windows.Forms.OpenFileDialog OpenFile_Image;
    }
}

