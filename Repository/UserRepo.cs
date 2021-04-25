using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestLaab1.Models;

namespace Repository
{
    public class UserRepo : IRepositoryBase<Users>
    {
        public ContextDb _db { get; set; }
        public UserRepo(ContextDb db)
        {
            _db = db;
        }
        public void Create(Users entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Remove(_db.User.FirstOrDefault(d => d.UserId == id));
        }

        public IQueryable<Users> FindAll()
        {
            return _db.User;
        }

        public Users FindById(int id)
        {
            return _db.User.FirstOrDefault(d => d.UserId == id);
        }
        public bool FindByName(string name)
        {
            if( _db.User.FirstOrDefault(d => d.UserName == name)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Users entity)
        {
            Users oldstd = _db.User.FirstOrDefault(d => d.UserId == entity.UserId);
            oldstd.UserName = entity.UserName;
            oldstd.Email = entity.Email;
            oldstd.Password = entity.Password;
        }
    }
}
