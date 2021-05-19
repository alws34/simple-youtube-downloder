using System;
using System.IO;
using System.Windows.Forms;

namespace ytd
{
    public partial class frmMainWindow : Form
    {
        /*******************/
        /***Constructors***/
        /*******************/
        public frmMainWindow()
        {
            InitializeComponent();
        }

        /*******************/
        /******Methods******/
        /*******************/
        public static string GetDefaultFolder() 
        {
            var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Path.Combine(home, "Downloads");
        }//get default download folder 

        /*******************/
        /*******Events******/
        /*******************/
        private void btnMP3convert_Click(object sender, EventArgs e)//start mp3 convertion form
        {
            Form mp3converter = new frmConvertTomp3(this);
            mp3converter.Show();
            Hide();
        }
        private void btn_download_vid_Click(object sender, EventArgs e)//start video converter form
        {
            Form youtubeDownloader = new frm_YoutubeDownloader(this);
            youtubeDownloader.Show();
            Hide();
        }
        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }//cleanup
    }
}
