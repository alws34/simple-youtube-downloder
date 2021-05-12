
namespace ytd
{
    partial class frm_YoutubeDownloader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_YoutubeDownloader));
            this.btn_Download = new System.Windows.Forms.Button();
            this.textBoxDownload_Location = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBox_Download_List = new System.Windows.Forms.ListBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(305, 336);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(129, 46);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // textBoxDownload_Location
            // 
            this.textBoxDownload_Location.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDownload_Location.Location = new System.Drawing.Point(74, 278);
            this.textBoxDownload_Location.Name = "textBoxDownload_Location";
            this.textBoxDownload_Location.Size = new System.Drawing.Size(596, 23);
            this.textBoxDownload_Location.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxDownload_Location, "paste here the folder path you want to download into. if left empty folder will b" +
        "e \"Downloads\" folder.");
            this.textBoxDownload_Location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDownload_Location_KeyDown);
            this.textBoxDownload_Location.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxDownload_Location_MouseMove);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(74, 307);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(596, 23);
            this.progressBar.TabIndex = 3;
            // 
            // listBox_Download_List
            // 
            this.listBox_Download_List.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_Download_List.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_Download_List.FormattingEnabled = true;
            this.listBox_Download_List.ItemHeight = 15;
            this.listBox_Download_List.Location = new System.Drawing.Point(74, 13);
            this.listBox_Download_List.Name = "listBox_Download_List";
            this.listBox_Download_List.Size = new System.Drawing.Size(596, 259);
            this.listBox_Download_List.TabIndex = 0;
            this.listBox_Download_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Videos_To_Download_KeyDown);
            this.listBox_Download_List.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox_Download_List_MouseMove);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(74, 336);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(83, 46);
            this.btnOpenFolder.TabIndex = 7;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(305, 307);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(0, 15);
            this.label_progress.TabIndex = 8;
            // 
            // frm_YoutubeDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(738, 474);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxDownload_Location);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.listBox_Download_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_YoutubeDownloader";
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox textBoxDownload_Location;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBox_Download_List;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label labelmp3convert;
        private System.Windows.Forms.Label label_progress;
    }
}

