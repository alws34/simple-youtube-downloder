using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ytd
{
    public partial class frmConvertTomp3 : Form
    {
        private string savemp3location;
        public frmConvertTomp3()
        {
            InitializeComponent();
        }


        private void addItemToconvertList()
        {
            string t = Clipboard.GetText();
            if (listBox_ConvertTomp3.Items.Contains(t) == false)
                listBox_ConvertTomp3.Items.Add(t);
        }

        private void addconvertLocation()
        {
            string dir = Clipboard.GetText();
            if (Directory.Exists(dir))
            {
                textBoxoutput.Text = dir;
            }
            else //if directory does not exist nor folder path is invlid
            {
                MessageBox.Show("please enter a valid path", "invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertToMp3_Click(object sender, EventArgs e) // start convertion
        {
            string output_location = textBoxoutput.Text;
            foreach (string item in listBox_ConvertTomp3.Items)
            {
                if (string.IsNullOrEmpty(textBoxoutput.Text))//if no save location selected, set default download location
                {
                    output_location = frmMainWindow.GetDefaultFolder();
                }

                var inputFile = item.Trim();
                var outputFile = item + ".mp3";

                var ffmpegProcess = new Process();
                ffmpegProcess.StartInfo.UseShellExecute = false;
                ffmpegProcess.StartInfo.RedirectStandardInput = true;
                ffmpegProcess.StartInfo.RedirectStandardOutput = true;
                ffmpegProcess.StartInfo.RedirectStandardError = true;
                ffmpegProcess.StartInfo.CreateNoWindow = true;
                ffmpegProcess.StartInfo.FileName = @"C:\FFmpeg\bin";
                ffmpegProcess.StartInfo.Arguments = inputFile + " " + outputFile;
                ffmpegProcess.Start();
                ffmpegProcess.StandardOutput.ReadToEnd();

                ffmpegProcess.WaitForExit();
                if (!ffmpegProcess.HasExited)
                {
                    ffmpegProcess.Kill();
                }
            }
        }

        private void btnsaveto_Click(object sender, EventArgs e) //where to save mp3 files
        {
            if (string.IsNullOrEmpty(textBoxoutput.Text))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    savemp3location = fbd.SelectedPath;
                    textBoxoutput.Text = savemp3location;
                }
            }
        }
        private void btnopenvideo_Click(object sender, EventArgs e)//get video files to convert and add them to the listbox
        {
            OpenFileDialog getvideos = new OpenFileDialog() { Multiselect = true, Filter = "MP4 file|*.mp4" };
            if (getvideos.ShowDialog() == DialogResult.OK)
            {
                foreach (string vidpath in getvideos.FileNames)
                {
                    listBox_ConvertTomp3.Items.Add(vidpath);
                }
            }
        }
        private void listBox_ConvertTomp3_KeyDown(object sender, KeyEventArgs e) // enabler ctrl+v to the listbox and enable deleting items from the list.
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                addItemToconvertList();
            }
            if (e.KeyCode == Keys.Delete)
            {
                listBox_ConvertTomp3.Items.Remove(listBox_ConvertTomp3.SelectedItem);
            }
        }
        private void listBox_ConvertTomp3_MouseMove(object sender, MouseEventArgs e)//TODO: 
        //build regex to accept only paths
        {
            //addItemToConvertList();
        } //add video paths to the convertion list with mouse movment over the list
        private void textBoxoutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                addconvertLocation();
            }
        } // add save-to path with ctrl+v
    }
}
