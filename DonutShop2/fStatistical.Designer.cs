
namespace DonutShop2
{
    partial class fStatistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // cThang
            // 
            chartArea1.Name = "ChartArea1";
            this.cThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cThang.Legends.Add(legend1);
            this.cThang.Location = new System.Drawing.Point(12, 12);
            this.cThang.Name = "cThang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "In";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Out";
            this.cThang.Series.Add(series1);
            this.cThang.Series.Add(series2);
            this.cThang.Size = new System.Drawing.Size(876, 278);
            this.cThang.TabIndex = 0;
            this.cThang.Text = "Statistics by month";
            // 
            // cNgay
            // 
            chartArea2.Name = "ChartArea1";
            this.cNgay.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cNgay.Legends.Add(legend2);
            this.cNgay.Location = new System.Drawing.Point(12, 308);
            this.cNgay.Name = "cNgay";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "In";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Out";
            this.cNgay.Series.Add(series3);
            this.cNgay.Series.Add(series4);
            this.cNgay.Size = new System.Drawing.Size(876, 314);
            this.cNgay.TabIndex = 1;
            this.cNgay.Text = "Statistics by date";
            // 
            // fStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.cNgay);
            this.Controls.Add(this.cThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStatistical";
            this.Text = "Statistical";
            ((System.ComponentModel.ISupportInitialize)(this.cThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart cNgay;
    }
}