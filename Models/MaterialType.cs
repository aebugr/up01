using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class MaterialType
    {
        public int idmaterial_type { get; set; }
        public string type { get; set; }
        public double defect_rate { get; set; }
        public MaterialType(int idmaterial_type, string type, double defect_rate)
        {
            this.idmaterial_type = idmaterial_type;
            this.type = type;
            this.defect_rate = defect_rate;
        }
    }
}
