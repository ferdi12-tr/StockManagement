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
    public class UserCrud : ICrud<User>
    {
        DataContext _db = new DataContext();
        public bool Add(User entity)
        {
            if (entity != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Surname)
                && !String.IsNullOrWhiteSpace(entity.Email)
                && !String.IsNullOrWhiteSpace(entity.Password))
            {
                _db.User.Add(entity);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var user = _db.User.Find(id);
            if (user != null)
            {
                user.IsDelete = true;
                _db.SaveChanges();
                return true;
            }
            throw new Exception("Cannot Delete");
        }

        public User GetById(int id)
        {
            var user = _db.User.Find(id);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public List<User> GetAll()
        {
            return _db.User.Where(x => x.IsDelete == false).ToList();
        }

        public bool Update(User entity, int id)
        {
            var user = _db.User.Find(id);
            if (user != null)
            {
                user.Name = entity.Name;
                user.Surname = entity.Surname;
                user.Description = entity.Description;
                user.RoleId = entity.RoleId;
                user.Email = entity.Email;
                user.Password = entity.Password;
                user.IsStatus = entity.IsStatus;
                user.Image = entity.Image;

                _db.SaveChanges();
                return true;
            }
            throw new Exception("Cannot Update Product");
        }
    }
}
