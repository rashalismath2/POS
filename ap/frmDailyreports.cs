using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BL;
using DAO;

namespace UI
{
    public partial class frmDailyreports : Form
    {
        Employee employee;
        public frmDailyreports(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void frmDailyreports_Load(object sender, EventArgs e)
        {
          int default_branch= createButtons();

            LoadDataBranchData(default_branch);
        }

        public int createButtons() {
            List<Branch> branches = new BranchDAO().getAllBranch();

            foreach (Branch branch in branches) {
                string btnName = "Branch "+branch.id.ToString();
                Button btn = new Button();

                btn.Width = 75;
                btn.Height = 23;
                btn.Text = btnName;
                btn.Name = "btn"+branch.id;
                btn.Font = new Font("Georgia", 9);
                btn.Click += new EventHandler(DynamicButton_Click);

                frmLayoutForButtons.Controls.Add(btn);
            }

            return branches[0].id;

        }
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int branch_id = int.Parse(button.Text.Split(' ')[1].ToString());

            LoadDataBranchData(branch_id);

        }

        public void LoadDataBranchData(int branch_id) {
            List<string[]> list=new TransactionDAO().getTransactionsGroupedByDate(branch_id);

            string[] dates =new string[list.Count];
            int[] total = new int[list.Count];

            int i = 0; 
            foreach (string[] item in list) {
                string dateString =item[0];
                DateTime dateFromString =
                    DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);

                dates[i] =dateFromString.Year.ToString()+"/"+ dateFromString.Month + "/"+ dateFromString.Day;
                total[i] = int.Parse(item[1]);
                i++;
            }

            var series = new Series("Total");
            series.Points.DataBindXY(dates, total);
            chartDailyTotal.Series.Clear();
            chartDailyTotal.Series.Add(series);
        }
    }
}
