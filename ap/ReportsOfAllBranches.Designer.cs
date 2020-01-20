namespace UI
{
    partial class ReportsOfAllBranches
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
            this.chartReportForAllBranch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportForAllBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReportForAllBranch
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReportForAllBranch.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReportForAllBranch.Legends.Add(legend1);
            this.chartReportForAllBranch.Location = new System.Drawing.Point(56, 24);
            this.chartReportForAllBranch.Name = "chartReportForAllBranch";
            this.chartReportForAllBranch.Size = new System.Drawing.Size(748, 453);
            this.chartReportForAllBranch.TabIndex = 1;
            this.chartReportForAllBranch.Text = "chart";
            // 
            // ReportsOfAllBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.chartReportForAllBranch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportsOfAllBranches";
            this.Text = "Reports Of All Branches";
            this.Load += new System.EventHandler(this.ReportsOfAllBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReportForAllBranch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReportForAllBranch;
    }
}