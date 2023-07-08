using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSyncApp
{
    public class SyncConfiguration
    {
        public string IpAddress {  get;  set; }
        public int UpdateRateInHours {  get;  set; }
        public bool autoUpdateEnabled { get;  set; }
    }
}
