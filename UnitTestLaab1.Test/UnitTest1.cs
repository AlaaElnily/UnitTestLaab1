
using Models;
using Repository;
using System;
using Xunit;

namespace UnitTestLaab1.Test
{
    public class UnitTest1
    {
        
        [Fact]
        public void CheckSeed()
        {
            ContextDb db = new ContextDb();
            UserRepo Ure = new UserRepo(db);
            RoleRepo Rre = new RoleRepo(db);
            UserRoleRepo URre = new UserRoleRepo(db);
            Assert.True(Ure.FindByName("Admin"));
            Assert.True(Rre.FindByName("Admin") != null);
            Assert.True(URre.FindByRoleId(1) != null);
        }
    }
}
