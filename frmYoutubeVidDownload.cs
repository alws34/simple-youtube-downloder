using System;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using System.Text.RegularExpressions;

namespace ytd
{
    public partial class frm_YoutubeDownloader : Form
    {
        /*******************/
        /******Fields*******/
        /*******************/
        string youtubeSTR = @"https://www.youtube.com/watch?v=";

        /*******************/
        /***Constructors***/
        /*******************/
        public frm_YoutubeDownloader()
        {
            InitializeComponent();
        }

        /*******************/
        /******Methods******/
        /*******************/
        private void addItemToDownloadList()
        {
            string t = Clipboard.GetText();
            if (t.Contains(youtubeSTR) && listBox_Download_List.Items.Contains(t) == false)
                listBox_Download_List.Items.Add(t);
        } //adding URLs to download list
        private void show_error(string message)
        {
            MessageBox.Show(message, "download_path not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //displays error message
        private void show_success(string message)
        {
            MessageBox.Show(message, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //show success message
        private void addDownloadLocation()
        {
            Regex download_Path_regex = new Regex("[A - Za - z:^\\]{ 1}[A-Za - z]*");//TODO
            string t = Clipboard.GetText();
            Match match = download_Path_regex.Match(t);
            if (t.Contains(youtubeSTR) == false && match.Success)
            {
                textBoxDownload_Location.Text = t;
            }
        } //add download location to the textbox
        private void DownloadVideo()
        {
            try
            {
                using (var service = Client.For(YouTube.Default))
                {
                    int items_count = listBox_Download_List.Items.Count;
                    int total_items = items_count;
                    int current_item = 1;
                    progressBar.Maximum = items_count;

                    string folder;
                    string download_path = textBoxDownload_Location.Text;

                    if (!string.IsNullOrEmpty(download_path) && Directory.Exists(download_path))
                        folder = download_path;
                    else
                        folder = frmMainWindow.GetDefaultFolder();

                    foreach (string URL in listBox_Download_List.Items)
                    {
                        var video = service.GetVideo(URL);
                        progressBar.Value += 1;
                        string path = Path.Combine(folder, video.FullName);
                        label_progress.Text = "item #" + current_item + " / " + total_items;
                        current_item += 1;  
                        File.WriteAllBytes(path, video.GetBytes()); //actual downloader
                        if (items_count == 0)
                        {
                            show_success("finished downloading all videos!\nyou can find them in: " + folder);
                            reset();
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                show_error("download_path not found!\nplease enter a valid download_path\n" + dnfe);
            }
            catch (Exception ex)
            {
                show_error(ex.ToString());
            }
        }
        private void reset()
        {
            listBox_Download_List.Items.Clear();
            label_progress.Text = "";
            progressBar.Value = 0;
        }

        /*******************/
        /*******Events******/
        /*******************/
        private void listBox_Videos_To_Download_KeyDown(object sender, KeyEventArgs e) //ctrl V and delete event for the download list 
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                addItemToDownloadList();
            }
            if (e.KeyCode == Keys.Delete)
            {
                listBox_Download_List.Items.Remove(listBox_Download_List.SelectedItem);
            }
        }
        private void btn_Download_Click(object sender, EventArgs e) //downloadBTN click event - does the actial downloading
        {
            DownloadVideo();
        }
        private void listBox_Download_List_MouseMove(object sender, MouseEventArgs e) //add items to download list with mouse hover 
        {
            addItemToDownloadList();
        }
        private void textBoxDownload_Location_MouseMove(object sender, MouseEventArgs e) //add download location with mouse hover
        {
            addDownloadLocation();
        }
        private void textBoxDownload_Location_KeyDown(object sender, KeyEventArgs e) //add download location with ctrl V
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                addDownloadLocation();
            }
        }
    }
}
