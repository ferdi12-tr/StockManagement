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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _db.User.Where(x => x.IsDelete == false).ToList();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
