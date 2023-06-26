using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace May31FtpUpload
{
    public class DownloadFtp
    {
        public string DownloadFtpFile(string url, string userName, string password, string localFilePath)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Credentials = new NetworkCredential(userName, password);
                webClient.DownloadFile(url, localFilePath);
                return "Downloaded Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message+"Downloading Failed";
            }

        }
        static void Main(string[] args)
        {
            string url = "ftp://183.82.96.182/Customer.xlsx";
            string userName = "Exam";
            string password = "Exam#321";
            string filePath = @"C:\Users\Asus\Desktop\Tecra_Training\Customer.xlsx";

            DownloadFtp downloadFtp = new DownloadFtp();    
            string message = downloadFtp.DownloadFtpFile(url, userName, password, filePath);
            Console.WriteLine(message);
        }
    }
}
