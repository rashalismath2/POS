using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBHelper
    {
        public static string connection() {
            return ConfigurationManager.ConnectionStrings["ad"].ConnectionString;
        }
    }
}
