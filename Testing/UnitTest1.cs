using System;
using Models;
using Repository;
using Xunit;
using UnitTestLaab1;
using UnitTestLaab1.Controllers;
using UnitTestLaab1.Models;

namespace Testing
{
    public class UnitTest1
    {
        ContextDb db = new ContextDb();
        
        [Fact]
        public void CheckSeed()
        {
            
            UserRepo Ure = new UserRepo(db);
            RoleRepo Rre = new RoleRepo(db);
            UserRoleRepo URre = new UserRoleRepo(db);
            Assert.True(Ure.FindByName("Admin")!=null);
            Roles r = new Roles();
            r = Rre.FindByName("Admin");
            Assert.True(r!=null);
            Assert.True(URre.FindByRoleId(r.RoleId) != null);
        }
        [Fact]
        public void LoginTrueTest()
        {
            ValuesController1 v = new ValuesController1(db);
            Assert.True(v.Login("Admin", "12345"));
        }
        [Fact]
        public void LoginFalseTest()
        {
            ValuesController1 v = new ValuesController1(db);
            Assert.False(v.Login("Alaa", "12345"));
        }
        [Fact]
        public void LoginFalseTest2()
        {
            ValuesController1 v = new ValuesController1(db);
            Assert.False(v.Login("Admin", "aaa"));
        }
        [Fact]
        public void LoginFalseTest3()
        {
            ValuesController1 v = new ValuesController1(db);
            Assert.False(v.Login("Alaa", "aaa"));
        }

    }
}
