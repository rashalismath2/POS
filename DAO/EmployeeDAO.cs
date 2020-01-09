using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using MySql.Data.MySqlClient;
using Dapper;

namespace DAO
{
    public class EmployeeDAO
    {
        public Employee saveEmployee(Employee emp) {

            using (MySqlConnection connection = getConnection()) {
                string query = @"insert into employee (first_name,last_name,email,password,role,branch_id) 
                        values(@first_name,@last_name,@email,@password,@role,@branch_id)";
                if (getEmployeeByEmail(emp.email) == null)
                {
                    int affectedRows = connection.Execute(query, new {
                           first_name=emp.first_name,
                           last_name=emp.last_name,
                           email=emp.email,
                           password=emp.password,
                           role=emp.role,
                           branch_id=emp.branch.id
                    });
                    if (affectedRows > 0)
                    {
                        return getEmployeeByEmail(emp.email);
                    }
                    else {
                        return null;
                    }
                }
                else {
                    return null;
                }
            }

        }

        public Employee getEmployeeByEmail(string email) {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from employee where email=@email";
                Employee emp = connection.QuerySingleOrDefault<Cashier>(query,new {email=email });

                if (emp!=null) {
                    string query2 = "select branch_id from employee where email=@email";
                    int id = connection.Query<int>(query2, new { email = email }).SingleOrDefault();
                    Branch branch=new BranchDAO().getBranchById(id);
                    emp.branch = branch;
                    return emp;
                }
                return null;
            }
        }

        private MySqlConnection getConnection() {
            return new MySqlConnection(DBHelper.connection());
        }
    }
}
