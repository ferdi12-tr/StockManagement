﻿using StockManagement.Entity.Interfaces;
using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

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
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
