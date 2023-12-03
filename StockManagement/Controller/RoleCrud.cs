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
    public class RoleCrud : ICrud<Role>
    {
        DataContext _db = new DataContext();
        public bool Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            var role = _db.Role.Find(id);
            if (role != null) return role;
            return null;
        }

        public bool Update(Role entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
