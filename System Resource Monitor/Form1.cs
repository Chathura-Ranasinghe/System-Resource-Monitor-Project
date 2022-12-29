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

namespace System_Resource_Monitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
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
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            metroLabelTime.Text = DateTime.Now.ToLongTimeString();
            metroLabelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void metroLabelDate_Click(object sender, EventArgs e)
        {

        }

        private void metroLabelTime_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                intcont.Image = Properties.Resources.connect;
                lblcont.Text = "        Connected";
                lblcont.ForeColor = Color.FromArgb(33, 230, 197);
            }
            else
            {
                intcont.Image = Properties.Resources.diconnect;
                lblcont.Text = "     Not Connected";
                lblcont.ForeColor = Color.FromArgb(240,89,69);
            }
        }

        private void lblcont_Click(object sender, EventArgs e)
        {

        }
    }
}
