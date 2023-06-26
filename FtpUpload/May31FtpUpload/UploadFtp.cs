using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace May31FtpUpload
{
    public class UploadFtp
    {
        public string UploadFtpFile(string ftpUrl, string username, string password, string filePath)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Credentials = new NetworkCredential(username, password);
                FileInfo fileInfo = new FileInfo(filePath);
                var fName=fileInfo.Name;
                var url = $"{ftpUrl}/{fName}";
                webClient.UploadFile(url, filePath);
                return "File uploaded successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
