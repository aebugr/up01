using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class Products
    {
        public int idproducts { get; set; }
        public int type_prod { get; set; }
        public string article { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double min_price { get; set; }
        public Products(int idproducts, int type_prod, string article, string name, string description, double min_price)
        {
            this.idproducts = idproducts;
            this.type_prod = type_prod;
            this.article = article;
            this.name = name;
            this.description = description;
            this.min_price = min_price;
        }
    }
}
