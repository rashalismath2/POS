using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SaleProduct
    {
        public int id { get; set; }
        public string name { get; set; }
        public int unitPrice { get; set; }
        public Branch branch { get; set; }
    }
}
