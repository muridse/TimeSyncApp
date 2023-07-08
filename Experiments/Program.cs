using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSyncService;
using System.Threading;


namespace Experiments
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Thread thread;
            string serverAddress = "91.207.136.55";
            var time = TimeSyncService.TimeSyncService.getInstance();
            Console.WriteLine(time.GetNetworkTime().ToLocalTime().ToString());
            Console.WriteLine(time.GetNetworkTime(serverAddress, true).ToLocalTime().ToString());
            var date = DateTime.Now.ToString().Split(' ');
            Console.WriteLine(date[0]);
            Console.WriteLine(date[1]);
            thread = new Thread(() => { Pim(); });
            thread.Start();

            Console.ReadLine();
            thread.Abort();

            thread = new Thread(() => { Pom(); });
            thread.Start();

            Console.ReadLine();
            thread.Abort();
        }
        public static void Pim() 
        {
            while (true) 
            {
                Thread.Sleep(1000);
                Console.WriteLine("pim");
            }
        }
        public static void Pom()
        {
            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine("pom");
            }
        }

    }
}
