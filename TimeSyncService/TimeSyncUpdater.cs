using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;

namespace TimeSyncService
{

    public class TimeSyncUpdater
    {
        Thread thread = null;
        private string NtpAddress {  get; set; }
        public TimeSyncUpdater(string ntpAddress) 
        {
            NtpAddress = ntpAddress;
        }
        public void StartUpdateEvery(int milliseconds) 
        {
            if (thread != null) thread.Abort();
            thread = new Thread(() => { Run(milliseconds); });
        }

        private void Run(int milliseconds) 
        {
            while (true) 
            {
                UpdateTime();
                Thread.Sleep(milliseconds);
            }
        }
        public void UpdateTime() 
        {
            var requester = NetworkTimeRequester.getInstance();
            var time = requester.GetNetworkTimeToLocal(NtpAddress);
            SetSystemDateTime(time);
        }
        private static void SetSystemDateTime(DateTime time)
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
