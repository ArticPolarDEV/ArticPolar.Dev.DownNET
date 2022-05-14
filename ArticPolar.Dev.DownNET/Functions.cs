using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticPolar.Dev.DownNET
{
    public class Functions
    {
        public static void Download(string url, string path, bool QuietDownload, bool ForceReplace)
        {
            if (ForceReplace == true)
            {
                if (File.Exists(@path)) { File.Delete(@path); }

                if (QuietDownload == true)
                {
                    WebClient net = new WebClient();
                    net.DownloadFile(new Uri(url), @path);
                }
                else if (QuietDownload == false)
                {
                    WebClient net = new WebClient();
                    net.DownloadFile(new Uri(url), @path);
                    Console.WriteLine("Download Sucessful");
                }
            }
            else if (ForceReplace == false)
            {
                if (QuietDownload == true)
                {
                    if (File.Exists(@path))
                    {
                        Replace(path); WebClient net3 = new WebClient();
                        net3.DownloadFile(new Uri(url), @path);
                    }

                    WebClient net2 = new WebClient();
                    net2.DownloadFile(new Uri(url), @path);
                }
                else if (QuietDownload == false)
                {
                    if (File.Exists(@path))
                    {
                        Replace(path);
                        WebClient net2 = new WebClient();
                        net2.DownloadFile(new Uri(url), @path);
                        Console.WriteLine("Download Sucessful");
                    }

                    WebClient net3 = new WebClient();
                    net3.DownloadFile(new Uri(url), @path);
                    Console.WriteLine("Download Sucessful");
                }
            }
        }
        public static void Replace(string file)
        {
            Console.WriteLine("The File: " + file + " exists, Replace? (Y/N): ");
            string RL = Console.ReadLine();
            if (RL.Equals("Y"))
            {
                File.Delete(@file);
            }
            else if (RL.Equals("N"))
            {
                Environment.Exit(0x00);
                Application.Exit();
                return;
            }

        }
    }
}
