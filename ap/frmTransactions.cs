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

namespace ap
{
    public partial class frmTransactions : Form
    {
        Employee employee;
        int unitprice=0;
        int total=0;
        List<SaleProduct> searchedProducts=new List<SaleProduct>();
        List<SaleProduct> salesProducts=new List<SaleProduct>();
        Customer customer;

        public frmTransactions(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            new frmAddCustomer(this.employee.branch,this).Show();
        }

        //getting the saved customer back from frmAddCustomer
        public void getCustomer(Customer customer) {
            this.customer = customer;
            txtCustomerEmailInput.Text = customer.email;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string prdctname = txtProductname.Text;
            int quentity =int.Parse(txtQuentity.Text);
            if (txtUnitPrice.Text != "")
            {
                foreach (SaleProduct prod in searchedProducts) {
                    if (prod.name== prdctname) {
                        salesProducts.Add(prod);
                    }
                }

                listCheckouts.Items.Add(prdctname + " | " + quentity + " | " + unitprice.ToString());
                txtUnitPrice.Text = "";
                txtProductname.Text = "";
                txtQuentity.Text = "";
                this.total = this.total+ (quentity * this.unitprice);
                txtTotal.Text = this.total.ToString();
            }
            else {
                MessageBox.Show("Add the product name", "Product cant be empty");
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (txtProductname.Text != "")
            {
                SaleProduct product = new ProductDAO().getSalesProduct(this.employee.branch, txtProductname.Text);
                if (product != null)
                {
                    this.searchedProducts.Add(product);
                    this.unitprice = product.unitPrice;
                    txtUnitPrice.Text = product.unitPrice.ToString();
                }
                else
                {
                    MessageBox.Show("Cant find the product", "Product not found");
                }
            }
            else {
                MessageBox.Show("Cant find the product", "Product not found");
            }

        }

        private void btnDoTrans_Click(object sender, EventArgs e)
        {
        
            int paid = int.Parse(txtPaid.Text);

            if (paid >= this.total)
            {
                txtPaid.Enabled = false;
                int balance = this.total - paid;

                if (this.customer==null) {
                    if (txtCustomerEmailInput.Text=="") {
                        MessageBox.Show("Please add a customer email", "customer not found");
                    }
                    else {
                        customer= new CustomerDAO().getCustomerByEmail(txtCustomerEmailInput.Text);
                    }
                }

                Transaction transaction = new Transaction
                {
                    customer = this.customer,
                    employee = this.employee,
                    saleProducts = this.salesProducts
                };

                bool saved = new TransactionDAO().saveTransactions(transaction);

                if (saved)
                {
                    MessageBox.Show("Transaction added", "success message");
                }
                else
                {
                    MessageBox.Show("Couldnt add the transaction", "error message");
                }


            }
            else {
                MessageBox.Show("Check for the paid amount", "Input error");
            }
        }

        private void CsutomerEmailFieldclicked(object sender, EventArgs e)
        {
            txtCustomerEmailInput.Text = "";
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            txtCustomerEmailInput.Text = "";
        }
    }
}
