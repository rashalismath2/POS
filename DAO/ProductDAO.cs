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
    public class ProductDAO
    {
        public List<SaleProduct> getAllSalesProducts(Branch branch)
        {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from saleproducts where branch_id=@branch_id";
                List<SaleProduct> SaleProduct = connection.Query<SaleProduct>(query,new { branch_id= branch.id }).ToList();

                if (SaleProduct != null)
                {
                    return SaleProduct;
                }
                return null;
            }
        }
        public SaleProduct getSalesProduct(Branch branch,string name)
        {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from saleproducts where branch_id=@branch_id and name=@name";
                SaleProduct SaleProduct = connection.QuerySingleOrDefault<SaleProduct>(query, new { branch_id = branch.id,name=name });

                if (SaleProduct != null)
                {
                    return SaleProduct;
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
