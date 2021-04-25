using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestLaab1.Models;

namespace Repository
{
    public class UserRoleRepo : IRepositoryBase<Users_Roles>
    {
        public ContextDb _db { get; set; }
        public UserRoleRepo(ContextDb db)
        {
            _db = db;
        }
        public void Create(Users_Roles entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Users_Roles> FindAll()
        {
            throw new NotImplementedException();
        }

        public Users_Roles FindByRoleId(int id)
        {
            return _db.User_Role.FirstOrDefault(d => d.RoleId == id);
        }

        public void Update(Users_Roles entity)
        {
            throw new NotImplementedException();
        }

        public Users_Roles FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
