using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Experiments
{
    internal class TimeUpdater
    {
        public TimeUpdater() { }
        private void Update() 
        {
            Console.WriteLine("Update Successfully");
        }
        public void Start(int ms) 
        {
            while (true) 
            {
                Update();
                Thread.Sleep(ms);
            }
        }
        public static void SetSystemDateTime(DateTime time)
        {

            string dateString = time.ToString().Split(' ')[0];
            string timeString = time.ToString().Split(' ')[1];

            // Формируем команду для изменения даты
            string setDateCommand = $"date {dateString}";

            // Формируем команду для изменения времени
            string setTimeCommand = $"time {timeString}";

            try
            {
                // Выполняем команду для изменения даты
                Process.Start("cmd.exe", "/C " + setDateCommand).WaitForExit();

                // Выполняем команду для изменения времени
                Process.Start("cmd.exe", "/C " + setTimeCommand).WaitForExit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
