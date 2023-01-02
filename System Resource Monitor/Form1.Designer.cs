namespace System_Resource_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SysUpTime = new System.Windows.Forms.Label();
            this.AvMemo = new System.Windows.Forms.Label();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.CountPCPU = new System.Windows.Forms.Label();
            this.CountLCPU = new System.Windows.Forms.Label();
            this.CountCores = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.intcont = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intcont)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(6, 280);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(255, 15);
            this.metroProgressBarCPU.TabIndex = 1;
            this.metroProgressBarCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(6, 280);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(255, 15);
            this.metroProgressBarRAM.TabIndex = 3;
            this.metroProgressBarRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.lblCPU.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCPU.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCPU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCPU.Location = new System.Drawing.Point(267, 280);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(30, 17);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "0 %";
            this.lblCPU.UseCustomBackColor = true;
            this.lblCPU.UseCustomForeColor = true;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.lblRAM.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRAM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRAM.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRAM.Location = new System.Drawing.Point(267, 280);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(30, 17);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "0 %";
            this.lblRAM.UseCustomBackColor = true;
            this.lblRAM.UseCustomForeColor = true;
            // 
            // metroLabelTime
            // 
            this.metroLabelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabelTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTime.ForeColor = System.Drawing.Color.White;
            this.metroLabelTime.Location = new System.Drawing.Point(0, 0);
            this.metroLabelTime.Name = "metroLabelTime";
            this.metroLabelTime.Size = new System.Drawing.Size(150, 17);
            this.metroLabelTime.TabIndex = 6;
            this.metroLabelTime.Text = "Time";
            this.metroLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelTime.UseCustomBackColor = true;
            this.metroLabelTime.UseCustomForeColor = true;
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabelDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDate.ForeColor = System.Drawing.Color.White;
            this.metroLabelDate.Location = new System.Drawing.Point(0, 28);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(150, 17);
            this.metroLabelDate.TabIndex = 7;
            this.metroLabelDate.Text = "Date";
            this.metroLabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelDate.UseCustomBackColor = true;
            this.metroLabelDate.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 510);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.intcont);
            this.panel5.Controls.Add(this.lblcont);
            this.panel5.Location = new System.Drawing.Point(0, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 125);
            this.panel5.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Network Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcont
            // 
            this.lblcont.Location = new System.Drawing.Point(0, 77);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(150, 29);
            this.lblcont.TabIndex = 15;
            this.lblcont.Text = "Internet\r\n";
            this.lblcont.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(150, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 78);
            this.panel4.TabIndex = 11;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(150, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 40);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(475, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 40);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel8.Controls.Add(this.chart1);
            this.panel8.Controls.Add(this.lblCPU);
            this.panel8.Controls.Add(this.metroProgressBarCPU);
            this.panel8.Location = new System.Drawing.Point(150, 110);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(325, 305);
            this.panel8.TabIndex = 14;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 40);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.SystemColors.ButtonHighlight;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(325, 240);
            this.chart1.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.panel9.Controls.Add(this.chart2);
            this.panel9.Controls.Add(this.metroProgressBarRAM);
            this.panel9.Controls.Add(this.lblRAM);
            this.panel9.Location = new System.Drawing.Point(475, 110);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(325, 305);
            this.panel9.TabIndex = 15;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(0, 40);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.SystemColors.ButtonHighlight;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Memory";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(325, 240);
            this.chart2.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.SysUpTime);
            this.panel10.Controls.Add(this.AvMemo);
            this.panel10.Controls.Add(this.CPUUsage);
            this.panel10.Location = new System.Drawing.Point(150, 415);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(325, 125);
            this.panel10.TabIndex = 16;
            // 
            // SysUpTime
            // 
            this.SysUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysUpTime.ForeColor = System.Drawing.Color.White;
            this.SysUpTime.Location = new System.Drawing.Point(200, 90);
            this.SysUpTime.Name = "SysUpTime";
            this.SysUpTime.Size = new System.Drawing.Size(100, 16);
            this.SysUpTime.TabIndex = 2;
            this.SysUpTime.Text = "#";
            this.SysUpTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AvMemo
            // 
            this.AvMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvMemo.ForeColor = System.Drawing.Color.White;
            this.AvMemo.Location = new System.Drawing.Point(200, 55);
            this.AvMemo.Name = "AvMemo";
            this.AvMemo.Size = new System.Drawing.Size(100, 16);
            this.AvMemo.TabIndex = 1;
            this.AvMemo.Text = "#";
            this.AvMemo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUUsage
            // 
            this.CPUUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUUsage.ForeColor = System.Drawing.Color.White;
            this.CPUUsage.Location = new System.Drawing.Point(200, 20);
            this.CPUUsage.Name = "CPUUsage";
            this.CPUUsage.Size = new System.Drawing.Size(100, 16);
            this.CPUUsage.TabIndex = 0;
            this.CPUUsage.Text = "#";
            this.CPUUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.CountPCPU);
            this.panel11.Controls.Add(this.CountLCPU);
            this.panel11.Controls.Add(this.CountCores);
            this.panel11.Location = new System.Drawing.Point(475, 415);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(325, 125);
            this.panel11.TabIndex = 17;
            // 
            // CountPCPU
            // 
            this.CountPCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountPCPU.ForeColor = System.Drawing.Color.White;
            this.CountPCPU.Location = new System.Drawing.Point(200, 90);
            this.CountPCPU.Name = "CountPCPU";
            this.CountPCPU.Size = new System.Drawing.Size(100, 16);
            this.CountPCPU.TabIndex = 5;
            this.CountPCPU.Text = "#";
            this.CountPCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountLCPU
            // 
            this.CountLCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLCPU.ForeColor = System.Drawing.Color.White;
            this.CountLCPU.Location = new System.Drawing.Point(200, 55);
            this.CountLCPU.Name = "CountLCPU";
            this.CountLCPU.Size = new System.Drawing.Size(100, 16);
            this.CountLCPU.TabIndex = 4;
            this.CountLCPU.Text = "#";
            this.CountLCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountCores
            // 
            this.CountCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountCores.ForeColor = System.Drawing.Color.White;
            this.CountCores.Location = new System.Drawing.Point(200, 20);
            this.CountCores.Name = "CountCores";
            this.CountCores.Size = new System.Drawing.Size(100, 16);
            this.CountCores.TabIndex = 3;
            this.CountCores.Text = "#";
            this.CountCores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 450;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "System Up Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available Memory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPU Usage";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.metroLabelDate);
            this.panel12.Controls.Add(this.metroLabelTime);
            this.panel12.Location = new System.Drawing.Point(3, 120);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(150, 45);
            this.panel12.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Count Of Phisical CPUs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Count Of Logical CPUs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Count Of Cores";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 80);
            this.panel3.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel13.Controls.Add(this.linkLabel1);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(800, 58);
            this.panel13.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCyan;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(650, 78);
            this.label8.TabIndex = 0;
            this.label8.Text = "System Resource Monitor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "CPU";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "Memory";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.pictureBox1.Image = global::System_Resource_Monitor.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // intcont
            // 
            this.intcont.Image = ((System.Drawing.Image)(resources.GetObject("intcont.Image")));
            this.intcont.Location = new System.Drawing.Point(0, 47);
            this.intcont.Name = "intcont";
            this.intcont.Size = new System.Drawing.Size(150, 32);
            this.intcont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.intcont.TabIndex = 13;
            this.intcont.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.Location = new System.Drawing.Point(207, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Copyright© 2023 All Rights Reserved by";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.Location = new System.Drawing.Point(448, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chathura Ranasinghe";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.Text = "RAM && CPU";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intcont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroLabel metroLabelTime;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.PictureBox intcont;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label SysUpTime;
        private System.Windows.Forms.Label AvMemo;
        private System.Windows.Forms.Label CPUUsage;
        private System.Windows.Forms.Label CountPCPU;
        private System.Windows.Forms.Label CountLCPU;
        private System.Windows.Forms.Label CountCores;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
    }
}

