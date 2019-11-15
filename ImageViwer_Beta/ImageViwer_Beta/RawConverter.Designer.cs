namespace ImageViwer_Beta
{
    partial class RawConverter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RawList = new System.Windows.Forms.ListBox();
            this.openRaw = new System.Windows.Forms.Button();
            this.convert_combo = new System.Windows.Forms.ComboBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browse_btn = new System.Windows.Forms.Button();
            this.SaveFileLocation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RawList);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 213);
            this.panel1.TabIndex = 0;
            // 
            // RawList
            // 
            this.RawList.FormattingEnabled = true;
            this.RawList.HorizontalScrollbar = true;
            this.RawList.Location = new System.Drawing.Point(13, 3);
            this.RawList.Name = "RawList";
            this.RawList.ScrollAlwaysVisible = true;
            this.RawList.Size = new System.Drawing.Size(151, 199);
            this.RawList.Sorted = true;
            this.RawList.TabIndex = 0;
            this.RawList.SelectedIndexChanged += new System.EventHandler(this.RawList_SelectedIndexChanged);
            // 
            // openRaw
            // 
            this.openRaw.Location = new System.Drawing.Point(12, 222);
            this.openRaw.Name = "openRaw";
            this.openRaw.Size = new System.Drawing.Size(75, 23);
            this.openRaw.TabIndex = 1;
            this.openRaw.Text = "OPEN";
            this.openRaw.UseVisualStyleBackColor = true;
            this.openRaw.Click += new System.EventHandler(this.openRaw_Click);
            // 
            // convert_combo
            // 
            this.convert_combo.FormattingEnabled = true;
            this.convert_combo.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "BMP"});
            this.convert_combo.Location = new System.Drawing.Point(183, 31);
            this.convert_combo.Name = "convert_combo";
            this.convert_combo.Size = new System.Drawing.Size(136, 21);
            this.convert_combo.TabIndex = 2;
            // 
            // convert_btn
            // 
            this.convert_btn.Location = new System.Drawing.Point(183, 151);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(149, 54);
            this.convert_btn.TabIndex = 3;
            this.convert_btn.Text = "CONVERT";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONVERT TO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save  to :";
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(183, 97);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(75, 23);
            this.browse_btn.TabIndex = 6;
            this.browse_btn.Text = "browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // SaveFileLocation
            // 
            this.SaveFileLocation.Location = new System.Drawing.Point(183, 71);
            this.SaveFileLocation.Name = "SaveFileLocation";
            this.SaveFileLocation.Size = new System.Drawing.Size(149, 20);
            this.SaveFileLocation.TabIndex = 7;
            // 
            // RawConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 257);
            this.Controls.Add(this.SaveFileLocation);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.convert_combo);
            this.Controls.Add(this.openRaw);
            this.Controls.Add(this.panel1);
            this.Name = "RawConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawConverter";
            this.Load += new System.EventHandler(this.RawConverter_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox RawList;
        private System.Windows.Forms.Button openRaw;
        private System.Windows.Forms.ComboBox convert_combo;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.TextBox SaveFileLocation;

    }
}