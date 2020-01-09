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
    public class BranchDAO
    {
        public Branch getBranchById(int id)
        {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from branch where id=@id";
                Branch branch = connection.QuerySingleOrDefault<Branch>(query, new { id = id });

                if (branch != null)
                {
                    return branch;
                }
                return null;
            }
        }
        public Branch getBranch(string branch_address)
        {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from branch where branch_address=@branch_address";
                Branch branch = connection.QuerySingleOrDefault<Branch>(query, new { branch_address = branch_address });

                if (branch != null)
                {
                    return branch;
                }
                return null;
            }
        }
        public List<Branch> getAllBranch()
        {
            using (MySqlConnection connection = getConnection())
            {
                string query = "select * from branch";
                List<Branch> branches = connection.Query<Branch>(query).ToList();

                if (branches != null)
                {
                    return branches;
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
