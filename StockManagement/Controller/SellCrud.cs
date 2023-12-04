using StockManagement.Data;
using StockManagement.Entity;
using StockManagement.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Controller
{
    internal class SellCrud : ICrud<SellProduct>
    {
        DataContext _db = new DataContext();
        public bool Add(SellProduct entity)
        {
            if (entity != null)
            {
                _db.SellProduct.Add(entity);
                _db.SaveChanges();
                return true;
            }
            return false;   
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SellProduct> GetAll()
        {
            return _db.SellProduct.ToList();
        }

        public SellProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(SellProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
