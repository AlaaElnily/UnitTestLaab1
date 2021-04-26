using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestLaab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {
        public ContextDb _db { get; set; }
        public ValuesController1(ContextDb db)
        {
            _db = db;
        }
        //public void UserRepo(ContextDb db)
        //{
        //    _db = db;
        //}
        public bool Login(string un, string pw)
        {
            if (_db.User.FirstOrDefault(d => d.UserName == un && d.Password == pw) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
