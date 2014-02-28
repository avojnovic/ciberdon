using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
    public static class UserManager
    {

        public static IEnumerable<User> Get(string username, string password)
        {
            CiberdonDbContext dbContext = new CiberdonDbContext();

            var res = from u in dbContext.User
                      where username == u.Email && password == u.Psw
                      select u;

            return res.ToList();
        }


    }
}
