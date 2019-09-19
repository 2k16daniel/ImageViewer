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
            this.components = new System.ComponentModel.Container();
            this.Button_PicOpen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Button_PicOpen
            // 
            this.Button_PicOpen.Location = new System.Drawing.Point(400, 356);
            this.Button_PicOpen.Name = "Button_PicOpen";
            this.Button_PicOpen.Size = new System.Drawing.Size(75, 32);
            this.Button_PicOpen.TabIndex = 1;
            this.Button_PicOpen.Text = "OPEN";
            this.Button_PicOpen.UseVisualStyleBackColor = true;
            this.Button_PicOpen.Click += new System.EventHandler(this.Button_PicOpen_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageList
            // 
            this.ImageList.Location = new System.Drawing.Point(-1, -3);
            this.ImageList.Name = "ImageList";
            this.ImageList.Size = new System.Drawing.Size(892, 353);
            this.ImageList.TabIndex = 2;
            this.ImageList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(888, 456);
            this.Controls.Add(this.ImageList);
            this.Controls.Add(this.Button_PicOpen);
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_PicOpen;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView ImageList;
    }
}

