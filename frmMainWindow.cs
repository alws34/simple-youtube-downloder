using System;
using System.IO;
using System.Windows.Forms;

namespace ytd
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        public static string GetDefaultFolder() //get default download folder 
        {
            var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Path.Combine(home, "Downloads");
        }
        private void btnMP3convert_Click(object sender, EventArgs e)//start mp3 convertion form
        {
            Form mp3converter = new frmConvertTomp3();
            mp3converter.Show();
        }
        private void btn_download_vid_Click(object sender, EventArgs e)//start video converter form
        {
            Form youtubeDownloader = new frm_YoutubeDownloader();
            youtubeDownloader.Show();
        }
    }
}
