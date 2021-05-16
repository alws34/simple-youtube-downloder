
namespace ytd
{
    partial class frmMainWindow
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
            this.btn_download_vid = new System.Windows.Forms.Button();
            this.btnMP3convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_download_vid
            // 
            this.btn_download_vid.Location = new System.Drawing.Point(12, 12);
            this.btn_download_vid.Name = "btn_download_vid";
            this.btn_download_vid.Size = new System.Drawing.Size(83, 43);
            this.btn_download_vid.TabIndex = 0;
            this.btn_download_vid.Text = "youtube downloader";
            this.btn_download_vid.UseVisualStyleBackColor = true;
            this.btn_download_vid.Click += new System.EventHandler(this.btn_download_vid_Click);
            // 
            // btnMP3convert
            // 
            this.btnMP3convert.Location = new System.Drawing.Point(224, 12);
            this.btnMP3convert.Name = "btnMP3convert";
            this.btnMP3convert.Size = new System.Drawing.Size(84, 43);
            this.btnMP3convert.TabIndex = 1;
            this.btnMP3convert.Text = "Convert files to mp3";
            this.btnMP3convert.UseVisualStyleBackColor = true;
            this.btnMP3convert.Click += new System.EventHandler(this.btnMP3convert_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 67);
            this.Controls.Add(this.btnMP3convert);
            this.Controls.Add(this.btn_download_vid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMainWindow";
            this.Text = "Youtube Downloader and converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_download_vid;
        private System.Windows.Forms.Button btnMP3convert;
    }
}