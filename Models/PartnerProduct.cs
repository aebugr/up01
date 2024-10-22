using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class PartnerProduct
    {
        public int idpartner_product { get; set; }
        public int product { get; set; }
        public int partner_name { get; set; }
        public int quantity_production { get; set; }
        public DateTime sale_date { get; set; }
        public PartnerProduct(int idpartner_product, int product, int partner_name, int quantity_production, DateTime sale_date)
        {
            this.idpartner_product = idpartner_product;
            this.product = product;
            this.partner_name = partner_name;
            this.quantity_production = quantity_production;
            this.sale_date = sale_date;
        }
    }
}
