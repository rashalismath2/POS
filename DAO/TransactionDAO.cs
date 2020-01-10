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
        public bool saveTransactions(Transaction transaction)
        {

            using (MySqlConnection connection = getConnection())
            {
                string query = @"insert into transaction (customer_id,employee_id,date) 
                        values(@customer_id,@employee_id,@date)";
                DateTime date = DateTime.Now;
                int affectedRows=connection.Execute(query, new {
                       customer_id=transaction.customer.id,
                       employee_id=transaction.employee.id,
                       date= date
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

        private MySqlConnection getConnection()
        {
            return new MySqlConnection(DBHelper.connection());
        }
    }
}
