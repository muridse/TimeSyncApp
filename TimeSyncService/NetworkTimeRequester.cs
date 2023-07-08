using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TimeSyncService
{
    public class NetworkTimeRequester
    {
        private static NetworkTimeRequester Instance { get; set; }
        protected NetworkTimeRequester() { }

        public static NetworkTimeRequester getInstance()
        {
            if (Instance == null)
                Instance = new NetworkTimeRequester();
            return Instance;
        }

        public DateTime GetNetworkTime(string ntpAdress = "pool.ntp.org", bool useIpIddress = false)
        {
            int timeout = 3000;
            IPEndPoint ipEndPoint;
            var ntpData = new byte[48];
            ntpData[0] = 0x1B; //LeapIndicator = 0 (no warning), VersionNum = 3 (IPv4 only), Mode = 3 (Client Mode)

            if (useIpIddress)
            {
                var ipAdress = IPAddress.Parse(ntpAdress);
                ipEndPoint = new IPEndPoint(ipAdress, 123);
            }
            else
            {
                var addresses = Dns.GetHostEntry(ntpAdress).AddressList;
                ipEndPoint = new IPEndPoint(addresses[0], 123);
            }
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            try
            {
                socket.Connect(ipEndPoint);
                socket.Send(ntpData);
                socket.ReceiveTimeout = timeout;
                socket.Receive(ntpData);
                socket.Close();
            }
            catch (Exception e)
            {
                return DateTime.MinValue; // NTP сервер доступен
                throw e;
            }

            if (ntpData == null && ntpData.Length < 48)
            {
                return DateTime.MinValue; // NTP сервер доступен
            }

            ulong intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | (ulong)ntpData[43];
            ulong fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | (ulong)ntpData[47];

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            var networkDateTime = (new DateTime(1900, 1, 1)).AddMilliseconds((long)milliseconds);

            return networkDateTime;
        }
        public DateTime GetNetworkTimeToLocal(string ntpAddress)
        {
            return GetNetworkTime(ntpAddress, true).ToLocalTime();
        }
        public DateTime GetNetworkTimeToLocal()
        {
            return GetNetworkTime().ToLocalTime();
        }
    }
}
