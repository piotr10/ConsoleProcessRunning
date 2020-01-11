using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProcessRunning
{
   public class Program
    {
        static void Main(string[] args)
        {
            /*
            MyProcess myProcess = new MyProcess();
            myProcess.BindToRunningProcesses();
            */

            string processName = "devenv";

            var processss = from proc in Process.GetProcesses() orderby proc.ProcessName select proc; // Its just need two line of code, you can use linq to get all processes.

            foreach (var item in processss)
            {
                //Console.WriteLine(item.ProcessName); // wypisuje wszystkie procesy na tablicy
                if (item.ProcessName == processName) //wpisujesz konkretna nazwe procesu
                {
                    Console.WriteLine("Znaleziono proces - {0}", processName); 
                    //znajduje konkretny proces i wypisuje, ze znaleziono
                    break;
                }
                Console.WriteLine(item.ProcessName + " - Błędny proces");
            }
        }
    }
}
