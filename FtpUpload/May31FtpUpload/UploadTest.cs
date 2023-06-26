using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May31FtpUpload
{
    public class UploadTest
    {
        static void Main(string[] args)
        {
            string url = "ftp://183.82.96.182";
            string userName = "Exam";
            string password = "Exam#321";
            string filePath = @"C:\Users\Asus\Desktop\Tecra_Training\Download.txt";

            UploadFtp uploadFtp = new UploadFtp();
            string message = uploadFtp.UploadFtpFile(url, userName, password, filePath);
            Console.WriteLine(message);
        }
    }
}
