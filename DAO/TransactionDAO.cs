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
    public class TransactionDAO
    {
        public List<string[]> getTransactionsGroupedByDate(int branch_id) {

            using (MySqlConnection connection = getConnection())
            {
                string query = @"select total,date from transaction where
                    employee_id in (select id from employee where branch_id in (@branch_Ids))
                group by date order by date desc  limit 7;";

                IEnumerable<dynamic> rows = connection.Query<dynamic>(query, new
                {
                    branch_Ids = branch_id
                });

                List<string[]> items =new List<string[]>();

             
                foreach (var row in rows)
                {
                    var fields = row as IDictionary<string, object>;
                    items.Add(new string[2] { fields["date"].ToString(), fields["total"].ToString() });

                }
                return items;

            }
        }
        public List<string[]> getTransactionForAllBranches()
        {

            using (MySqlConnection connection = getConnection())
            {
                string query = @"select b.id,sum(t.total) as total from transaction as t
                        inner join employee as e on e.id=t.employee_id
                        inner join branch as b on b.id=e.branch_id group by b.id; ";

                IEnumerable<dynamic> rows = connection.Query<dynamic>(query);

                List<string[]> items = new List<string[]>();


                foreach (var row in rows)
                {
                    var fields = row as IDictionary<string, object>;
                    items.Add(new string[2] { fields["id"].ToString(), fields["total"].ToString() });

                }
                return items;

            }
        }

        public bool saveTransactions(Transaction transaction)
        {

            using (MySqlConnection connection = getConnection())
            {
                string query = @"insert into transaction (customer_id,employee_id,date,total) 
                        values(@customer_id,@employee_id,@date,@total)";
                DateTime date = DateTime.Now;
                int affectedRows=connection.Execute(query, new {
                       customer_id=transaction.customer.id,
                       employee_id=transaction.employee.id,
                       date= date,
                       total= transaction.total
                });
                if (affectedRows>0) {
                    Transaction savedTransaction = getTransaction(transaction.customer.id,transaction.employee.id,date);
                    foreach (SaleProduct product in transaction.saleProducts) {
                        saveTransactionItems(savedTransaction.id, product.id);
                    }
                    return true;
                }
                else { return false; }

            }

        }

        public bool saveTransactionItems(int transaction_id,int saleproducts_id) {

            using (MySqlConnection connection = getConnection())
            {
                string query = @"insert into transaction_items (transaction_id,saleproducts_id) 
                        values(@transaction_id,@saleproducts_id)";
                int affectedRows = connection.Execute(query, new
                {
                    transaction_id = transaction_id,
                    saleproducts_id = saleproducts_id,
                });
                if (affectedRows > 0)
                {
                    return true;
                }
                else {
                    return false;
                }

            }
        }
        //getTransaction(customer.id, this.employee.branch)
        public Transaction getTransaction(int customerId,int employeeId,DateTime date) {

            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from transaction where customer_id=@customer_id and employee_id=@employee_id and DATE(date)=@date limit 1";
                Transaction transaction = connection.QuerySingleOrDefault<Transaction>(query, new {
                    customer_id = customerId,
                    employee_id = employeeId,
                    date=date.ToString("yyyyMMdd")
                });

                if (transaction != null)
                {
                    return transaction;
                }
                return null;
            }
        
        }

        public List<Transaction> getTransactionForTheCustomer(int customerId)
        {

            using (MySqlConnection connection = getConnection())
            {
                string query = @" select 
                         t.id as transaction_id,
                         t.total as total,
                         t.date as date,
                          t.employee_id as employee_id,
                         sp.id as product_id,
                         sp.name as product_name,
                         sp.unitPrice as unit_price,
                         sp.branch_id as branch_id
                         from transaction_items as ti inner join saleproducts as sp on sp.id=ti.saleproducts_id
                        inner join  transaction as t on t.id=ti.transaction_id
                         where t.customer_id=@customer_id;";

                IEnumerable<dynamic> rows = connection.Query<dynamic>(query,new {
                    customer_id=customerId
                });

                //create an empty list to save the transactions
                List<Transaction> items = new List<Transaction>();

                //Iterate through all the transactions and add transaction obejct to the list
                foreach (var row in rows)
                {
                    var fields = row as IDictionary<string, object>;

                    bool found = false;
                    foreach (Transaction trans in items) {
                        if (int.Parse(fields["transaction_id"].ToString()) ==trans.id) {
                            found = true;
                        }
                    }
                    if (!found) {
                        items.Add(new Transaction {
                            id =int.Parse(fields["transaction_id"].ToString()),
                            total=int.Parse(fields["total"].ToString()),
                            date=(DateTime)fields["date"],
                            employee = new Cashier {id=int.Parse(fields["employee_id"].ToString()) },
                            saleProducts=new List<SaleProduct> { new SaleProduct {
                                id=int.Parse(fields["product_id"].ToString()),
                                name=fields["product_name"].ToString(),
                                branch=new Branch { id=int.Parse(fields["branch_id"].ToString())}
                            } }
                        });
                    }
                     
                }
                return items;

            }

        }



        private MySqlConnection getConnection()
        {
            return new MySqlConnection(DBHelper.connection());
        }
    }
}
