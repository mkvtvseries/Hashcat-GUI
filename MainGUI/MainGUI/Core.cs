using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MainGUI
{
    public static class Core
    {
        #region Declatarion Stuff
        public static WebClient client = null;
        public static Form1 main;
        private static Dictionary<double, Thread> threadPool = new Dictionary<double, Thread>();
        private static ManualResetEvent syncEvent = new ManualResetEvent(false);
        #endregion
        public static void Init(Form1 frm)
        {
            main = frm;
        }
        public static void StopProcesses(string name)
        {
            foreach (Process p in Process.GetProcessesByName(name))
            {
                p.Kill();
            }
        }
        public static Thread RunThread_Download(string url, string path, Thread runAfter = null)
        {
            ManualResetEvent syncEvent = new ManualResetEvent(false);
            double unixMilli = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
            Thread newThread = new Thread(
        () =>
        {
            syncEvent.Set();
            using (client = new WebClient()){
                client.DownloadFileAsync(new Uri(url), path);
                client.DownloadFileCompleted += delegate{
                    if (runAfter != null)
                    {
                        runAfter.Start();
                    }
                };
            };
            syncEvent.WaitOne();
            threadPool.Remove(unixMilli);
        }

    );
            if (threadPool.ContainsKey(unixMilli))
            {
                Thread.Sleep(5);
                threadPool.Add(unixMilli, newThread);
            }

            newThread.Start();
            return newThread;
        }
        public static Thread RunThread(Action methodName)
        {
            ManualResetEvent syncEvent = new ManualResetEvent(false);
            double unixMilli = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
            Thread newThread = new Thread(
        () =>
        {
            syncEvent.Set();
            methodName();
            syncEvent.WaitOne();
            threadPool.Remove(unixMilli);
        }

    );
            if (threadPool.ContainsKey(unixMilli))
            {
                Thread.Sleep(5);
                threadPool.Add(unixMilli, newThread);
            }

            newThread.Start();
            return newThread;
        }
        public static void CloseAllThreads()
        {
            foreach (double key in threadPool.Keys)
            {
                threadPool[key].Abort();
            }
        }
        public static string DoRequest(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AllowAutoRedirect = true;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);


                string output = readStream.ReadToEnd();
                return output;
            }
            catch
            {
                return "";
            }
        }
        public static string StringBetween(string s1, string s2, string full)
        {
            string output = full.Split(new string[] { s1 }, StringSplitOptions.None)[1];
            output = output.Split(new string[] { s2 }, StringSplitOptions.None)[0];
            return output;
        }
    }
}
