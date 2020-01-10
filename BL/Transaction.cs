using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Transaction
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public Customer customer { get; set; }
        public DateTime date { get; set; }
        public List<SaleProduct> saleProducts { get; set; }
    }
}
