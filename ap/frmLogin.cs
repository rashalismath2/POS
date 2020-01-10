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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee employee = new EmployeeDAO().getEmployeeByEmail(txtemail.Text);
            if (employee!= null) {
                if (employee.password==txtPassword.Text) {

                    UI.Properties.Settings.Default.email = txtemail.Text;
                    UI.Properties.Settings.Default.password = txtPassword.Text;
                    UI.Properties.Settings.Default.Save();

                    frmdashboard dashboard = new frmdashboard(employee);
                    dashboard.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Error in login. Check credentials", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else {
                MessageBox.Show("Error in login. Check credentials", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            frmSignup signupForm = new frmSignup();
            signupForm.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
