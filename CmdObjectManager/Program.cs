using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CmdObjectManager.Mem;
using System.Diagnostics;

namespace CmdObjectManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A sample ObjectManager by http://zzuks.blogspot.ch");

            int pid = Process.GetProcessesByName("WoW")[0].Id;
            BmWrapper.mem.OpenProcessAndThread(Process.GetProcessesByName("WoW")[0].Id);
            Console.WriteLine("Attaching to pid: " + pid + Environment.NewLine
                + "Starting ObjectManager ...");

            Manager.getObjects();
            
        }
    }
}
