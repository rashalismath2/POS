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
    public partial class frmSignup : Form
    {
        List<Branch> branches;
        public frmSignup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Employee emp;

            Branch branch=new BranchDAO().getBranch(comboBranchAddress.Text);

            if (branch==null) {
               MessageBox.Show("Error on signup", "Signup error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            switch (comboSignupRole.Text) {
                case "cashier":
                    emp = new Cashier
                    {
                        first_name = txtSignupFIrstName.Text,
                        last_name=txtSignupLastName.Text,
                        email=txtSignupEmail.Text,
                        role=comboSignupRole.Text,
                        branch=branch,
                        password= txtSignupPassword.Text
                    };
                    break;
                default:
                    emp = null;
                    break;
            }
            emp = new EmployeeDAO().saveEmployee(emp);
            if (emp != null)
            {
                frmdashboard dashboard = new frmdashboard(emp);
                dashboard.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Error on signup", "Signup error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            };

        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            branches = new BranchDAO().getAllBranch();
            if (branches!=null) {
                string[] branchArr = new string[branches.Count()];
                int i = 0;
                foreach (var branch in branches)
                {
                    branchArr[i++] = branch.branch_address;
                }
                comboBranchAddress.Items.AddRange(branchArr);
            }
        }
    }
}
