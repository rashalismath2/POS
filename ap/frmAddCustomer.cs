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
using DAO;

namespace ap
{
    public partial class frmAddCustomer : Form
    {
        Branch branch;
        frmTransactions transactions;
        public frmAddCustomer(Branch branch,frmTransactions transactions)
        {
            InitializeComponent();
            this.branch = branch;
            this.transactions = transactions;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer {
                 first_name = txtCustomerFirstName.Text,
                 last_name = txtCustomerLastname.Text,
                 gender = comboCustomerGender.Text,
                 email = txtCustomerEmail.Text,
                 branch=branch
        };

            customer=new CustomerDAO().saveCustomer(customer);

            if (customer != null)
            {
                this.transactions.getCustomer(customer);
                DialogResult result= MessageBox.Show("added the customer", "Success",MessageBoxButtons.OK);
                if (result==DialogResult.OK) {
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Couldnt add the customer","Error");
            }

        }
    }
}
