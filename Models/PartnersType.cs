using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugrina_UP01.Models
{
    public class PartnersType
    {
        public int idpartners_type { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public PartnersType(int idpartners_type, string type, string name)
        {
            this.idpartners_type = idpartners_type;
            this.type = type;
            this.name = name;
        }
    }
}
