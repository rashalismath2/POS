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
    public partial class frmCustomer : Form
    {
        Employee employee;
        List<Customer> customers;
        public frmCustomer(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            customers=new CustomerDAO().getAllSalesProducts(employee.branch);
            dataGridCustomers.DataSource = customers;
            
        }

        private void btnCustomerTrans_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount =dataGridCustomers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount>= 0)
            {

                int id = int.Parse(dataGridCustomers.SelectedRows[0].Index.ToString());
                if (id >= 0)
                {
                    Customer customer = customers.ElementAt(id);
                    List<Transaction> transactions = new TransactionDAO().getTransactionForTheCustomer(customer.id);
            
                    new frmTransactionDetails(transactions).Show();
                }
            }
            else {
                MessageBox.Show("Select a row");
            }

        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
