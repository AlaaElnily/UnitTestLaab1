using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestLaab1.Models;

namespace Repository
{
    public class RoleRepo : IRepositoryBase<Roles>
    {
        public ContextDb _db { get; set; }
        RoleRepo(ContextDb db)
        {
            db = _db;
        }
        public void Create(Roles entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Remove(_db.Role.FirstOrDefault(d => d.RoleId == id));
        }

        public IQueryable<Roles> FindAll()
        {
            return _db.Role;
        }

        public Roles FindById(int id)
        {
            return _db.Role.FirstOrDefault(d => d.RoleId == id);
        }

        public void Update(Roles entity)
        {
            Roles oldrole = _db.Role.FirstOrDefault(d => d.RoleId == entity.RoleId);
            oldrole.RoleName = entity.RoleName;
        }
    }
}
