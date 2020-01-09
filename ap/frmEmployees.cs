using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnEmployeeRecords_Click(object sender, EventArgs e)
        {
             new frmEmployeeDetails().Show();
        }

        private void btnEmployeeAttendance_Click(object sender, EventArgs e)
        {
            new frmEmployeeAttandnce().Show();
        }
    }
}
