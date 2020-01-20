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
        frmdashboard dashboard;
        public frmLogin(frmdashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }
        private bool matchHashes(string inputPassword, string dbPassword)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputPassword);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            if (hash == dbPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee employee = new EmployeeDAO().getEmployeeByEmail(txtemail.Text);
            if (employee!= null) {
                if (matchHashes(txtPassword.Text,employee.password)) {

                    UI.Properties.Settings.Default.email = txtemail.Text;
                    UI.Properties.Settings.Default.password = txtPassword.Text;
                    UI.Properties.Settings.Default.Save();

                    if (this.dashboard==null) {
                        frmdashboard dashboard = new frmdashboard(employee);
                        dashboard.Show();
                        this.Hide();
                    }
                    else {
                        this.dashboard.setUser(employee);
                        this.dashboard.Show();
                        this.Hide();
                    }
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
