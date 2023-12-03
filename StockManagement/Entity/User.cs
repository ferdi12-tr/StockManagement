using StockManagement.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entity
{
    public class User : CommonProperties
    {
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Order> OrderList { get; set; }
        public List<BuyProduct> BuyProductList { get; set; }
    }
}
