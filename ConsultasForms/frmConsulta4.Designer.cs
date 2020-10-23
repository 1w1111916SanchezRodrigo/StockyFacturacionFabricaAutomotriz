namespace DistribuidoraCrelech.ConsultasForms
{
    partial class frmConsulta4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDonut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDonut
            // 
            this.chartDonut.BackColor = System.Drawing.Color.Transparent;
            this.chartDonut.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartDonut.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartDonut.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDonut.Legends.Add(legend2);
            this.chartDonut.Location = new System.Drawing.Point(108, 25);
            this.chartDonut.Name = "chartDonut";
            this.chartDonut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.chartDonut.Series.Add(series2);
            this.chartDonut.Size = new System.Drawing.Size(349, 261);
            this.chartDonut.TabIndex = 0;
            this.chartDonut.Text = "chart";
            // 
            // frmConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 287);
            this.Controls.Add(this.chartDonut);
            this.Name = "frmConsulta4";
            this.Text = "frmConsulta4";
            this.Load += new System.EventHandler(this.frmConsulta4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDonut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDonut;
    }
}