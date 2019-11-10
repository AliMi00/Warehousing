using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing.Models
{
    public class ProductsAndSold
    {
        public List<Product> products { get; set; }
        public List<SoldProduct> soldProducts { get; set; }

    }
}
