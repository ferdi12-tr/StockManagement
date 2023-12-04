using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<User> UserList { get; set; }
        public int ProductId { get; set; }
        public List<Product> ProductList { get; set; }
        public DateTime OrderDateTime { get; set; }

        public int Quantity { get; set; }
        public bool İsDelete { get; set; }
        public List<SellProduct> SellProductList { get; set; }

        //temporarySolution
        [NotMapped]
        public string ProductName { get; set; }
        [NotMapped]
        public string UserName { get; set; }

        [NotMapped]
        public double TotalPayAmount { get; set; }
    }
}
