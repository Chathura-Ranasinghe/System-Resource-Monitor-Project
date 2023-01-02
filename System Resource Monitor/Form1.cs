using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Management;

namespace System_Resource_Monitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        PerformanceCounter perfCPU = new PerformanceCounter("Processor","% Processor Time","_Total");
        PerformanceCounter perfRAM = new PerformanceCounter("Memory","Available MBytes");
        PerformanceCounter perfSYS = new PerformanceCounter("System","System Up Time");

        public Form1()
        {
            InitializeComponent();
        }

        private int CountOfPhysCores()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string socketDesign = string .Empty;
            List<string> physCPU = new List<string>();

            if (!physCPU.Contains(socketDesign)) 
            { 
                physCPU.Add(socketDesign);
            }

            return physCPU.Count;
        }

        private int CountOfLogicalCores()
        {
            int logCPU = 0;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            logCPU++;

            return logCPU;
        }

        public bool pingStatus()
        {
            bool pingStatus = false;
            string hostNameOrAddress = "Google.com";

            using (Ping p = new Ping())
            {
                string data = "aaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;

                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingStatus = (reply.Status == IPStatus.Success);
                }
                catch(Exception)
                { 
                    pingStatus= false;
                }
                return pingStatus;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart2.Series["Memory"].Points.AddY(fram);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            timer1.Start();
            metroLabelTime.Text = DateTime.Now.ToShortTimeString();
            metroLabelDate.Text = DateTime.Now.ToShortDateString();

            foreach(var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                CountPCPU.Text = item["NumberOfProcessors"]+"";
            }
            int coreCount = 0;
            foreach(var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }

            CountCores.Text = coreCount.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                intcont.Image = Properties.Resources.connect;
                lblcont.Text = "Connected";
                lblcont.ForeColor = Color.FromArgb(33, 230, 197);
            }
            else
            {
                intcont.Image = Properties.Resources.diconnect;
                lblcont.Text = "Not Connected";
                lblcont.ForeColor = Color.FromArgb(240,89,69);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CPUUsage.Text = (int)perfCPU.NextValue() + " %";
            AvMemo.Text = (int)perfRAM.NextValue() + "";
            SysUpTime.Text = (int)perfSYS.NextValue()/60 + " min.";

            CountLCPU.Text = Environment.ProcessorCount.ToString();
        }
    }
}
