namespace UI
{
    partial class frmDailyreports
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
            this.chartDailyTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frmLayoutForButtons = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDailyTotal
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDailyTotal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDailyTotal.Legends.Add(legend2);
            this.chartDailyTotal.Location = new System.Drawing.Point(28, 30);
            this.chartDailyTotal.Name = "chartDailyTotal";
            this.chartDailyTotal.Size = new System.Drawing.Size(728, 453);
            this.chartDailyTotal.TabIndex = 0;
            this.chartDailyTotal.Text = "chart1";
            // 
            // frmLayoutForButtons
            // 
            this.frmLayoutForButtons.Location = new System.Drawing.Point(759, 75);
            this.frmLayoutForButtons.Name = "frmLayoutForButtons";
            this.frmLayoutForButtons.Size = new System.Drawing.Size(111, 366);
            this.frmLayoutForButtons.TabIndex = 1;
            // 
            // frmDailyreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 504);
            this.Controls.Add(this.frmLayoutForButtons);
            this.Controls.Add(this.chartDailyTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDailyreports";
            this.Text = "Daily Report";
            this.Load += new System.EventHandler(this.frmDailyreports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyTotal;
        private System.Windows.Forms.FlowLayoutPanel frmLayoutForButtons;
    }
}