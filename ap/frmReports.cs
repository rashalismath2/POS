using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;


namespace UI
{
    public partial class frmReports : Form
    {
        Employee employee;
        public frmReports(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmDailyreports rep = new frmDailyreports(this.employee);
            rep.Show();
        }

        private void btnTotalByBranches_Click(object sender, EventArgs e)
        {
            ReportsOfAllBranches allBranch = new ReportsOfAllBranches();
            allBranch.Show();
        }
    }
}
