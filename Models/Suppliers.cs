using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class Suppliers
    {
        public int idsuppliers { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Suppliers(int idsuppliers, string type, string name)
        {
            this.idsuppliers = idsuppliers;
            this.type = type;
            this.name = name;
        }
    }
}
