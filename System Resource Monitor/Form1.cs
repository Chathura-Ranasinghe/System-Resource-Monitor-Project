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

namespace System_Resource_Monitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            metroLabelTime.Text = DateTime.Now.ToLongTimeString();
            metroLabelDate.Text = DateTime.Now.ToLongDateString();
        }

        /*private void metroLabelTime_Click(object sender, EventArgs e)
        {
            metroLabelTime.Text = DateTime.Now.ToLongTimeString();
            metroLabelDate.Text = DateTime.Now.ToShortDateString();
        }*/
    }
}
