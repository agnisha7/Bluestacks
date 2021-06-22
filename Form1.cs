using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FileDownloader
{
    public partial class frmFileDownloader : Form
    {
        public frmFileDownloader()
        {
            InitializeComponent();
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbDwnload.Value = e.ProgressPercentage;
            lblDwnloadPercent.Visible = true;
            lblDwnloadPercent.Text = lblDwnloadPercent.Text+" "+ pbDwnload.Value.ToString() + "%";
        }

        private void btnDwnload_Click(object sender, EventArgs e)
        {
             Uri uri = new Uri(tbURL.Text);

            //create downloaded file name file extracting from URL
            string filename = "";
            try
            {
                filename = System.IO.Path.GetFileName(uri.LocalPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show("File path is incorrect!");
            }
            using (WebClient wc = new WebClient())
            {
                //add event handler for progressbar
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                try
                {
                    //check if file already exists as downloaded file
                    if (!File.Exists(tbDestination.Text + "\\" + filename))
                        try
                        {
                            wc.DownloadFileAsync(new System.Uri(tbURL.Text), tbDestination.Text + "\\" + filename);
                        }
                        catch
                        {
                            MessageBox.Show("The URL is incorrect!");
                        }
                    else
                    {
                        MessageBox.Show("File already exists!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Download for file failed. File may be missing at the location.");
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbDestination.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
           
        }
    }
}
