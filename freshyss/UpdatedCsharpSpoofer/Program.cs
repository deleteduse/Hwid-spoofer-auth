using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;

namespace ConsoleApp4
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        private const string RequestUri = "https://pastebin.com/raw/ifrKYSkB";// your paste bin link here 

        static void Main(string[] args)
        {
            var hwid = GetHWID();
            CheckHWID(hwid);

        }

        private static string GetHWID()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography"; string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null) throw new KeyNotFoundException(string.Format(location));
                    object HWID = rk.GetValue(name);
                    if (HWID == null) throw new IndexOutOfRangeException(string.Format(name));
                    return HWID.ToString();
                }
            }
        }


        static async void CheckHWID(string hwid)

        {
            var client = new HttpClient();
            var database = await client.GetAsync(RequestUri).Result.Content.ReadAsStringAsync();
            if (database.Contains(hwid))
            {

                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("+");
                Console.ResetColor();
                Console.Write("] HWID Authorized!");
                Console.ReadLine();
            }
            else
            {
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("+");
                Console.ResetColor();
                Console.Write("] made by !deleted user#8167  \n");// change this to some like contact !deleted user#8167 for white list etc
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("+");
                Console.ResetColor();
                Console.Write("] HWID: " + hwid + "\n");
                Console.ReadLine();


            };
            if (database.Contains(hwid))
            {

                Console.ForegroundColor = ConsoleColor.Cyan;// change color here
                Console.Title = "" + "!deleted user#8167";
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("For cool text here vist ");
                Console.WriteLine("http://patorjk.com/software/taag/#p=display&f=CeA&t=spoof");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Type 1 or 2");
                Console.WriteLine("");
                Console.WriteLine("1 = spoof");
                Console.WriteLine("2 = serials");
                Console.WriteLine("3 = clean/spoof mac");
                string r = Console.ReadLine();
                if (r == "1")
                {
                    Download();
                }
                if (r == "2")
                {
                    serials();
                }
                if (r =="3")
                {
                    clean();
                
                }
            }
        }


        private static void clean()
        {
            WebClient D = new WebClient();
            string exe = ("C:/Windows/IME/");//put end on your file here exsample spoof.sys
            D.DownloadFile("", exe);// put your download link to your file discord link works fine
            Process start = new Process();
            start.StartInfo.FileName = "Cmd.exe";
            start.StartInfo.UseShellExecute = true;
            start.StartInfo.CreateNoWindow = true;
            start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            start = Process.Start(exe);
            Thread.Sleep(2000);
        }



        private static void serials()
        {
            WebClient D = new WebClient();
            string bat = ("C:/Windows/IME/Serials.bat");///put end on your file here exsample spoof.sys
            D.DownloadFile("", bat);// put your download link to your file discord link works fine
            Process start = new Process();
            start.StartInfo.FileName = "Cmd.bat";
            start.StartInfo.UseShellExecute = true;
            start.StartInfo.CreateNoWindow = true;
            start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            start = Process.Start(bat);
            Thread.Sleep(2000);
        }

        private static void Download()
        {
            WebClient D = new WebClient();
            string sys = ("C:/Windows/IME/");//put end on your file here exsample spoof.sys
            string mapper = ("C:/Windows/IME/");//put end on your file here exsample spoof.sys
            D.DownloadFile("", sys);
            D.DownloadFile("", mapper);// put your download link to your file discord link works fine
            Process start = new Process();
            start.StartInfo.FileName = "Cmd.exe";
            start.StartInfo.UseShellExecute = true;
            start.StartInfo.CreateNoWindow = true;
            start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            start = Process.Start(mapper, sys);
            Thread.Sleep(2000);
            start.Close();
            string bb = ("C:/Windows/IME/");//put end on your file here exsample spoof.sys
            D.DownloadFile("", bb);// put your download link to your file discord link works fine
            start.StartInfo.FileName = "Cmd.exe";
            start.StartInfo.UseShellExecute = true;
            start.StartInfo.CreateNoWindow = true;
            start.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            start = Process.Start(bb);
            Thread.Sleep(15000);
            start.Close();
            Thread.Sleep(9000);
            Console.Clear();
        }
    }
}

