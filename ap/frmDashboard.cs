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

namespace ap
{
    public partial class frmdashboard : Form
    {
        Employee employee;
        public frmdashboard(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = this.employee.first_name + " " + this.employee.last_name;

            if (this.employee.role == "cashier") {
                btnEmployees.Hide();
                btnReports.Hide();
                btnInventory.Hide();
            }
            else if (this.employee.role == "inventory_manager") {
                btnEmployees.Hide();
                btnTransaction.Hide();
            }

            frmTransactions trans = new frmTransactions(this.employee);
            trans.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(trans);
            trans.Show();

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransactions trans = new frmTransactions(this.employee);
            trans.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(trans);
            trans.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer cstmr = new frmCustomer();
            cstmr.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(cstmr);
            cstmr.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees emp = new frmEmployees();
            emp.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(emp);
            emp.Show();

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(inventory);
            inventory.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
