using StockManagement.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entity
{
    public class Product : CommonProperties
    {
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BuyProduct> BuyProductList { get; set; }
        public List<SellProduct> SellProductList { get; set; }

    }
}
