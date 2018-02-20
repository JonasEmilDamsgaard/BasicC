using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        
        
     

        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher fsw = new System.IO.FileSystemWatcher(@"C:\temp", "*.txt");

            fsw.EnableRaisingEvents = true;
            fsw.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;

            fsw.Changed += Fsw_Changed;

            do { } while (true);
        }

        private static void Fsw_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }
}
