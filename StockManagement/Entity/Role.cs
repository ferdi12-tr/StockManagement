using StockManagement.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entity
{
    public class Role : CommonProperties
    {
        public List<User> UserList { get; set; }
    }
}
