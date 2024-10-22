using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class ProductType
    {
        public int idproduct_type { get; set; }
        public string type { get; set; }
        public double coefficient { get; set; }
        public ProductType(int idproduct_type, string type, double coefficient)
        {
            this.idproduct_type = idproduct_type;
            this.type = type;
            this.coefficient = coefficient;
        }
    }
}
