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
    public class ProductCrud : ICrud<Product>
    {
        DataContext _db = new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Description))
            {
                _db.Product.Add(entity);
                _db.SaveChanges();
                return true;
            }
            return false; 
        }

        public bool Delete(int id)
        {
            var product = _db.Product.Find(id);
            if (product != null)
            {
                product.IsDelete = true;
                _db.SaveChanges();
                return true;
            }
            throw new Exception("Cannot Delete");
        }

        public List<Product> GetAll()
        {
            return _db.Product.Where(x => x.IsDelete == false).ToList();
        }

        public Product GetById(int id)
        {
            var product = _db.Product.Find(id);
            if (product != null)
                return product;
            throw new Exception("Product Found Error");
        }

        public bool Update(Product entity, int id)
        {
            var product = _db.Product.Find(id);
            if (product != null)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.Category = entity.Category;
                product.Price = entity.Price;
                product.IsStatus = entity.IsStatus;
                product.Stock = entity.Stock;
                product.Image = entity.Image;

                _db.SaveChanges();
                return true;
            }
            throw new Exception("Cannot Update Product");
        }
    }
}
