using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing.Models
{
    public class WareHousStatus
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int QuantityExist { get; set; }
        public int QuantitySold { get; set; }

    }
}
