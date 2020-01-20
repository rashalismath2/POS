using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAO;

namespace ap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Check if the user has saved password to remember. else call the login
            if (UI.Properties.Settings.Default.email != string.Empty && UI.Properties.Settings.Default.password != string.Empty)
            {
                //get the employee details from db by its email
                Employee employee = new EmployeeDAO().getEmployeeByEmail(UI.Properties.Settings.Default.email);

                //check if the password matches.
                if (UI.Properties.Settings.Default.password == employee.password)
                {
                    //if passwords are matches call dashboard
                    Application.Run(new frmdashboard(employee));
                }
                else {
                    //else redirect to login
                    Application.Run(new frmLogin(null));
                }

            }
            else {
                Application.Run(new frmLogin(null));
            }
        }
    }
}
