using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class Materials
    {
        public int idmaterials { get; set; }
        public int type { get; set; }
        public string name { get; set; }
        public int idsupplier { get; set; }
        public int quantity_package { get; set; }
        public string description { get; set; }
        public Materials(int idmaterials, int type, string name, int idsupplier, int quantity_package, string description)
        {
            this.idmaterials = idmaterials;
            this.type = type;
            this.name = name;
            this.idsupplier = idsupplier;
            this.quantity_package = quantity_package;
            this.description = description;
        }
    }
}
