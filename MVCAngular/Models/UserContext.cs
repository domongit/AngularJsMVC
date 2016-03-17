using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAngular.Models
{
    public class UserContext
    {
        private UserEntity _userEnt;
        public IEnumerable<User> GetAllUsers()
        {
            _userEnt = new UserEntity();
            return _userEnt.Users;
        }
    }
}