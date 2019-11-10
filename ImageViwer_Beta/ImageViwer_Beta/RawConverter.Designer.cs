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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RawList);
            this.panel1.Location = new System.Drawing.Point(82, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 213);
            this.panel1.TabIndex = 0;
            // 
            // RawList
            // 
            this.RawList.FormattingEnabled = true;
            this.RawList.Location = new System.Drawing.Point(13, 3);
            this.RawList.Name = "RawList";
            this.RawList.Size = new System.Drawing.Size(151, 199);
            this.RawList.TabIndex = 0;
            // 
            // openRaw
            // 
            this.openRaw.Location = new System.Drawing.Point(135, 231);
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
            this.convert_combo.Location = new System.Drawing.Point(82, 289);
            this.convert_combo.Name = "convert_combo";
            this.convert_combo.Size = new System.Drawing.Size(177, 21);
            this.convert_combo.TabIndex = 2;
            // 
            // convert_btn
            // 
            this.convert_btn.Location = new System.Drawing.Point(82, 333);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(177, 76);
            this.convert_btn.TabIndex = 3;
            this.convert_btn.Text = "CONVERT";
            this.convert_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONVERT TO :";
            // 
            // RawConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.convert_combo);
            this.Controls.Add(this.openRaw);
            this.Controls.Add(this.panel1);
            this.Name = "RawConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawConverter";
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

    }
}