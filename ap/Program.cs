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

            if (UI.Properties.Settings.Default.email != string.Empty && UI.Properties.Settings.Default.password != string.Empty)
            {
                Employee employee = new EmployeeDAO().getEmployeeByEmail(UI.Properties.Settings.Default.email);

                if (UI.Properties.Settings.Default.password == employee.password)
                {
                    Application.Run(new frmdashboard(employee));
                }
                else {
                    Application.Run(new frmLogin(null));
                }

            }
            else {
                Application.Run(new frmLogin(null));
            }
        }
    }
}
