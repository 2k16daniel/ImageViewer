namespace ImageViwer_Beta
{
    partial class PhotoList
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
            this.ImageListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ImageListBox
            // 
            this.ImageListBox.FormattingEnabled = true;
            this.ImageListBox.Location = new System.Drawing.Point(31, 22);
            this.ImageListBox.Name = "ImageListBox";
            this.ImageListBox.Size = new System.Drawing.Size(223, 355);
            this.ImageListBox.TabIndex = 0;
            this.ImageListBox.SelectedIndexChanged += new System.EventHandler(this.ImageListBox_SelectedIndexChanged);
            // 
            // PhotoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 417);
            this.Controls.Add(this.ImageListBox);
            this.Name = "PhotoList";
            this.Text = "PhotoList";
            this.Load += new System.EventHandler(this.PhotoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ImageListBox;
    }
}