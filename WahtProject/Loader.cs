using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using xNet;

namespace WahtProject
{
    class Loader
    {
        public static bool rabota = false;

        public static List<string> AgentList = new List<string>();

        public static List<string> sourceList = new List<string>();

        public static List<string> sourceOst = new List<string>();

        public static List<string> proxyList = new List<string>();

        public static List<Thread> threadList = new List<Thread>();

        public static int good = 0, bad = 0, error = 0, captcha = 0;

        public static int count = 0;

        public static string soft = "Uplaybyleniawar";

        public static string time = DateTime.Now.ToString("HH_mm_ss");

        public string path = "Result\\";

        public static void Update_Proxy(string URL)
        {
            proxyList.Clear();
            using (HttpRequest httpRequest = new HttpRequest())
            {
                httpRequest.Cookies = new CookieDictionary();
                httpRequest.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; SM-G892A Build/NRD90M; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/60.0.3112.107 Mobile Safari/537.36";
                string result = httpRequest.Get(URL).ToString();
                File.Delete("proxy-from-URL.txt");
                File.AppendAllText("proxy-from-URL.txt", result);
                proxyList = File.ReadAllLines("proxy-from-URL.txt").ToList();
                File.Delete("proxy-from-URL.txt");
            }
        }
        public static string GetProxy()
        {
            Random Rand = new Random();
            return Convert.ToString(proxyList[Rand.Next(0, proxyList.Count)]);
        }
        public static void Source()
        {
            var FileDialog = new OpenFileDialog(); FileDialog.Filter = ".txt)|*.txt";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceList.Clear();
                sourceList.AddRange(File.ReadAllLines(FileDialog.FileName));
                sourceOst.Clear();
                sourceOst.AddRange(File.ReadLines(FileDialog.FileName));
            }
        }
        public static void Proxy()
        {
            var FileDialog = new OpenFileDialog(); FileDialog.Filter = ".txt|*.txt";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                proxyList.Clear();
                proxyList.AddRange(File.ReadAllLines(FileDialog.FileName));
            }
        }
    }
}
