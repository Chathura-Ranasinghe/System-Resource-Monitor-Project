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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.intcont = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intcont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            this.metroProgressBarCPU.Location = new System.Drawing.Point(6, 245);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(255, 15);
            this.metroProgressBarCPU.TabIndex = 1;
            this.metroProgressBarCPU.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(6, 245);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(255, 15);
            this.metroProgressBarRAM.TabIndex = 3;
            this.metroProgressBarRAM.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCPU.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCPU.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblCPU.Location = new System.Drawing.Point(267, 245);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(35, 20);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "0 %";
            this.lblCPU.UseCustomBackColor = true;
            this.lblCPU.UseCustomForeColor = true;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRAM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRAM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblRAM.Location = new System.Drawing.Point(267, 245);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(35, 20);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "0 %";
            this.lblRAM.UseCustomBackColor = true;
            this.lblRAM.UseCustomForeColor = true;
            // 
            // metroLabelTime
            // 
            this.metroLabelTime.AutoSize = true;
            this.metroLabelTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTime.ForeColor = System.Drawing.Color.White;
            this.metroLabelTime.Location = new System.Drawing.Point(668, 22);
            this.metroLabelTime.Name = "metroLabelTime";
            this.metroLabelTime.Size = new System.Drawing.Size(39, 17);
            this.metroLabelTime.TabIndex = 6;
            this.metroLabelTime.Text = "Time";
            this.metroLabelTime.UseCustomBackColor = true;
            this.metroLabelTime.UseCustomForeColor = true;
            this.metroLabelTime.Click += new System.EventHandler(this.metroLabelTime_Click);
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDate.ForeColor = System.Drawing.Color.White;
            this.metroLabelDate.Location = new System.Drawing.Point(33, 20);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(37, 17);
            this.metroLabelDate.TabIndex = 7;
            this.metroLabelDate.Text = "Date";
            this.metroLabelDate.UseCustomBackColor = true;
            this.metroLabelDate.UseCustomForeColor = true;
            this.metroLabelDate.Click += new System.EventHandler(this.metroLabelDate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.metroLabelDate);
            this.panel1.Controls.Add(this.metroLabelTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.intcont);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 510);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 80);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblcont);
            this.panel5.Location = new System.Drawing.Point(0, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 100);
            this.panel5.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "  Network Status";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblcont.Location = new System.Drawing.Point(0, 84);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(50, 16);
            this.lblcont.TabIndex = 15;
            this.lblcont.Text = "Internet\r\n";
            this.lblcont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcont.Click += new System.EventHandler(this.lblcont_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(150, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 80);
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
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(150, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 40);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Location = new System.Drawing.Point(475, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 40);
            this.panel7.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::System_Resource_Monitor.Properties.Resources.memo;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(325, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::System_Resource_Monitor.Properties.Resources.cpu1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(325, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // intcont
            // 
            this.intcont.Image = ((System.Drawing.Image)(resources.GetObject("intcont.Image")));
            this.intcont.Location = new System.Drawing.Point(22, 147);
            this.intcont.Name = "intcont";
            this.intcont.Size = new System.Drawing.Size(100, 50);
            this.intcont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.intcont.TabIndex = 13;
            this.intcont.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::System_Resource_Monitor.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::System_Resource_Monitor.Properties.Resources.srm;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(650, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.chart1);
            this.panel8.Controls.Add(this.lblCPU);
            this.panel8.Controls.Add(this.metroProgressBarCPU);
            this.panel8.Location = new System.Drawing.Point(150, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(325, 265);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Controls.Add(this.chart2);
            this.panel9.Controls.Add(this.metroProgressBarRAM);
            this.panel9.Controls.Add(this.lblRAM);
            this.panel9.Location = new System.Drawing.Point(475, 150);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(325, 265);
            this.panel9.TabIndex = 15;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(325, 240);
            this.chart1.TabIndex = 5;
            // 
            // chart2
            // 
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Memory";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(325, 240);
            this.chart2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(800, 600);
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
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intcont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.PictureBox intcont;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

