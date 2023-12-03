using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Entity.Abstracts;

namespace StockManagement.Entity
{
    public class Category : CommonProperties
    {
        public List<Product> ProductList { get; set; }
    }
}
