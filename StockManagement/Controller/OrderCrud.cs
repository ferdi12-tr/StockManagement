using StockManagement.Entity.Interfaces;
using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;
using System.CodeDom;

namespace StockManagement.Controller
{
    public class OrderCrud : ICrud<Order>
    {
        DataContext _db = new DataContext();
        public bool Add(Order entity)
        {
            if (entity != null)
            {
                _db.Order.Add(entity);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var order = _db.Order.Find(id);
            if (order != null)
            {
                order.İsDelete = true;
                _db.SaveChanges();
                return true;
            }
            throw new Exception("Cannot Delete Order");
        }

        public List<Order> GetAll()
        {
            return _db.Order.Where(x => x.İsDelete == false).ToList();
        }

        public Order GetById(int id)
        {
            var order = _db.Order.Find(id);
            if (order != null)
            {
                return order;
            }
            throw new Exception("Order not Found");
        }

        public bool Update(Order entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
