using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamesTool
{
    internal class Main
    {
        public void DownloadManifest(string appid)
        {
            if (!CheckForExist(appid)) { return; }

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Choose folder to save";
            folderDialog.ShowNewFolderButton = true;
            string url = $"https://steamdatabase1.s3.eu-north-1.amazonaws.com/{appid}.zip";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;
                ManifestResponse(url, selectedPath, appid);
            }
            
        }
        public void ManifestResponse(string url, string path, string appid)
        {
            if (string.IsNullOrEmpty(url)) { return; }
            string path_filename = $"{path}/{appid}.zip";
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, path_filename);
                    MessageBox.Show("Manifest saved in path: " + path_filename, "✔ Ready");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "❌ Error");
            }
        }
        public bool CheckForExist(string appid)
        {
            string url = $"https://steamdatabase1.s3.eu-north-1.amazonaws.com/{appid}.zip";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return true ;
                    }
                    else
                    {
                        MessageBox.Show("AppId doesn't exist", "❌ Error");
                        return false ;
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse errorResponse)
                {
                    MessageBox.Show($"{(int)errorResponse.StatusCode} {errorResponse.StatusDescription}", "❌ Error");
                    return false ;
                }
                else
                {
                    MessageBox.Show(ex.Message, "❌ Error on connect");
                    return false ;
                }
            }

        }
    }
}
