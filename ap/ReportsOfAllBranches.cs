using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BL;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class ReportsOfAllBranches : Form
    {
        public ReportsOfAllBranches()
        {
            InitializeComponent();
        }

        private void ReportsOfAllBranches_Load(object sender, EventArgs e)
        {
            getBranchComparisonData();
        }

        private void getBranchComparisonData() {
     
            List<string[]> list = new TransactionDAO().getTransactionForAllBranches();

            string[] dates = new string[list.Count];
            int[] total = new int[list.Count];

            int i = 0;
            foreach (string[] item in list)
            {
                string branch ="Branch "+ item[0];

                dates[i] = branch;
                total[i] = int.Parse(item[1]);
                i++;
            }

            var series = new Series("Total");
            series.Points.DataBindXY(dates, total);
            chartReportForAllBranch.Series.Clear();
            chartReportForAllBranch.Series.Add(series);
        }
    }
}
