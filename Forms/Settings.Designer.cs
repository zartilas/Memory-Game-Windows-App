namespace FinalErgasia1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.labelImages = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.comboImages = new System.Windows.Forms.ComboBox();
            this.labelImagesFound = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.BackColor = System.Drawing.Color.Transparent;
            this.labelImages.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelImages.Location = new System.Drawing.Point(14, 82);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(107, 27);
            this.labelImages.TabIndex = 0;
            this.labelImages.Text = "Images:";
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSettings.Location = new System.Drawing.Point(8, 11);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(166, 40);
            this.labelSettings.TabIndex = 1;
            this.labelSettings.Text = "Settings";
            // 
            // comboImages
            // 
            this.comboImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboImages.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboImages.FormattingEnabled = true;
            this.comboImages.Items.AddRange(new object[] {
            "Default Images",
            "Custom Images"});
            this.comboImages.Location = new System.Drawing.Point(127, 80);
            this.comboImages.Name = "comboImages";
            this.comboImages.Size = new System.Drawing.Size(207, 30);
            this.comboImages.TabIndex = 2;
            this.comboImages.SelectionChangeCommitted += new System.EventHandler(this.comboImages_SelectionChangeCommitted);
            // 
            // labelImagesFound
            // 
            this.labelImagesFound.AutoSize = true;
            this.labelImagesFound.BackColor = System.Drawing.Color.Transparent;
            this.labelImagesFound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelImagesFound.Location = new System.Drawing.Point(129, 123);
            this.labelImagesFound.Name = "labelImagesFound";
            this.labelImagesFound.Size = new System.Drawing.Size(35, 13);
            this.labelImagesFound.TabIndex = 3;
            this.labelImagesFound.Text = "label1";
            this.labelImagesFound.Visible = false;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Location = new System.Drawing.Point(348, 14);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(302, 61);
            this.panelInfo.TabIndex = 5;
            this.panelInfo.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInfo.Location = new System.Drawing.Point(5, 5);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(296, 52);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "To select Custom Images you must meet the following criteria:\r\n* Icons must be of" +
    " png filetype.\r\n* Directory must have 12 images.\r\n* Recommended image size is 12" +
    "8x128.";
            this.labelInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 516);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelImagesFound);
            this.Controls.Add(this.comboImages);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.labelImages);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.ComboBox comboImages;
        private System.Windows.Forms.Label labelImagesFound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
    }
}