using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TimeSyncService;

namespace TimeSyncApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(LoadConfiguration()));
            
        }
        static SyncConfiguration LoadConfiguration() 
        {
            string path = ".config";
            bool fileExist = File.Exists(path);
            if (!fileExist) return null;

            //1line - ip
            //2line - update rate
            //3line - auto update enable flag
            List<string> lines = new List<string>();
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   lines.Add(line.Split(' ')[2]);
                }
            }
            return new SyncConfiguration()
            {
                IpAddress = lines[0],
                UpdateRateInHours = int.Parse(lines[1]),
                autoUpdateEnabled = lines[2] == "true" ? true : false 
            };
        }
    }
}
