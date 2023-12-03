using StockManagement.Entity.Interfaces;
using StockManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Controller
{
    public class CategoryCrud : ICrud<Category>
    {
        DataContext _db = new DataContext();
        public bool Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _db.Category.Where(x => x.IsDelete == false).ToList();
        }

        public Category GetById(int id)
        {
            var category = _db.Category.Find(id);
            if (category != null)
                return category;
            throw new Exception("Cannot Found Category");
        }

        public bool Update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
