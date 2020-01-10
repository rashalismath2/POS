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
    public class CustomerDAO
    {
        public Customer saveCustomer(Customer customer)
        {

            using (MySqlConnection connection = getConnection())
            {
                string query = @"insert into customer (first_name,last_name,email,branch_id) 
                        values(@first_name,@last_name,@email,@branch_id)";

                int affectedRows=connection.Execute(query, new {
                                first_name =customer.first_name,
                                last_name=customer.last_name,
                                email=customer.email,
                                branch_id=customer.branch.id
                });

                if (affectedRows > 0)
                {
                    return getCustomerByEmail(customer.email);
                }
                else {
                    return null;
                }
            }

        }

        public Customer getCustomerByEmail(string email)
        {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from customer where email=@email";
                Customer customer = connection.QuerySingleOrDefault<Customer>(query, new { email = email });

                if (customer != null)
                {
                    string query2 = "select branch_id from customer where email=@email";
                    int id = connection.Query<int>(query2, new { email = email }).SingleOrDefault();
                    Branch branch = new BranchDAO().getBranchById(id);
                    customer.branch = branch;
                    return customer;
                }
                return null;
            }
        }

        private MySqlConnection getConnection()
        {
            return new MySqlConnection(DBHelper.connection());
        }
    }
}
