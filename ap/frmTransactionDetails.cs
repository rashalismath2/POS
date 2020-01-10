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
    public partial class frmTransactionDetails : Form
    {
        List<Transaction> transactions;
        public frmTransactionDetails(List<Transaction> transactions)
        {
            InitializeComponent();
            this.transactions = transactions;
        }

        private void dataGridCustomerTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTransactionDetails_Load(object sender, EventArgs e)
        {
            dataGridCustomerTrans.DataSource = this.transactions;

            int total = 0;
            foreach (Transaction trans in transactions) {
                total = total + trans.total;
            }

            txtTotalCustomerTransactions.Text = total.ToString();

        }
    }
}
