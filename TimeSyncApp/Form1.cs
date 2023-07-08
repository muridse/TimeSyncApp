using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeSyncService;

namespace TimeSyncApp
{

    public partial class Form1 : Form
    {
        private SyncConfiguration SyncConfiguration {get; set;}
        private TimeSyncUpdater TimeSyncUpdater { get; set; }
        public Form1(SyncConfiguration syncConfiguration)
        {
            SyncConfiguration = syncConfiguration;
            TimeSyncUpdater = new TimeSyncUpdater(SyncConfiguration.IpAddress);
            InitializeComponent();

            //string adr = "91.206.16.3";

            ipAdressField.Text = SyncConfiguration.IpAddress;
            
            checkBox1.Checked = SyncConfiguration.autoUpdateEnabled;
            successLabel.Visible = SyncConfiguration.autoUpdateEnabled;

            timeOutput.ReadOnly = true;
            timeOutputLocal.ReadOnly = true;

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 72;
            trackBar1.TickFrequency = 12;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.Value = SyncConfiguration.UpdateRateInHours;
            updateRateLabel.Text = String.Format("{0} ч.", trackBar1.Value);
            // When window state changed, trigger state update.
            this.Resize += SetMinimizeState;
            // When tray icon clicked, trigger window state change.       
            notifyIcon1.Click += ToggleMinimizeState;


            TimeSyncUpdater.StartUpdateEvery(hoursToMs(SyncConfiguration.UpdateRateInHours));

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            updateRateLabel.Text = String.Format("{0} ч.", trackBar1.Value);
        }

        private void showTime(object sender, EventArgs e)
        {
            timeOutput.Text = GetNetTimeString();
            timeOutputLocal.Text = DateTime.Now.ToString();

        }
        // Toggle state between Normal and Minimized.
        private void ToggleMinimizeState(object sender, EventArgs e)
        {
            bool isMinimized = this.WindowState == FormWindowState.Minimized;
            this.WindowState = (isMinimized) ? FormWindowState.Normal : FormWindowState.Minimized;
        }

        // Show/Hide window and tray icon to match window state.
        private void SetMinimizeState(object sender, EventArgs e)
        {
            bool isMinimized = this.WindowState == FormWindowState.Minimized;

            this.ShowInTaskbar = !isMinimized;
            notifyIcon1.Visible = isMinimized;
            if (isMinimized) notifyIcon1.ShowBalloonTip(500, "Time Sync", "Приложение свернуто в трей.", ToolTipIcon.Info);
        }
        private string GetNetTimeString() 
        {
            var adr = ipAdressField.Text;
            var time = NetworkTimeRequester.getInstance();
            DateTime serverTimeNow = time.GetNetworkTime(adr, true);
            if (serverTimeNow == DateTime.MinValue)
                return "Error NTP receving! Check IP-address.";
            else return serverTimeNow.ToLocalTime().ToString();
        }

        private void setSettings(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                TimeSyncUpdater.StartUpdateEvery(hoursToMs(trackBar1.Value));
                successLabel.Visible = true;
            }
            else
                successLabel.Visible = false;
        }

        private void updateTime(object sender, EventArgs e)
        {
            TimeSyncUpdater.NtpAddress = ipAdressField.Text;
            TimeSyncUpdater.UpdateTime();
            showTime(sender, e);
        }
        private int hoursToMs(int hours) 
        {
            var minutes = hours * 60;
            var seconds = minutes * 60;
            return seconds * 1000;
        }
    }
}
