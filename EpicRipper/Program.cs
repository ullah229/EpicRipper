using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;


namespace EpicRipper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                foreach (Process p in Process.GetProcesses())
                {
                    string name = p.ProcessName.ToLower();
                    if (name == "epicgameslauncher") p.Kill();
                }
                Thread.Sleep(10000);
            }
        }
    }
}

