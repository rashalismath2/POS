using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Employee
    {
        public string role { get; set; }
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Branch branch { get; set; }

    }
}
