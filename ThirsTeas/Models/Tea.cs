using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirsTeas.Models
{
    public class Tea
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Flavour Flavour { get; set; }
        public  Type Type { get; set;  }
    }
}
