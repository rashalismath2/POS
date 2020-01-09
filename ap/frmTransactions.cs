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

        public frmTransactions(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            new frmAddCustomer().Show();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string prdctname = txtProductname.Text;
            int quentity =int.Parse(txtQuentity.Text);
            if (txtUnitPrice.Text != "")
            {
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
                MessageBox.Show("Transaction added", "success message");
            }
            else {
                MessageBox.Show("Check for the paid amount", "Input error");
            }
        }
    }
}
