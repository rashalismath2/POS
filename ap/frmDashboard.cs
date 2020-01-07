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
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            frmTransactions trans = new frmTransactions();
            trans.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(trans);
            trans.Show();

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransactions trans = new frmTransactions();
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
    }
}
