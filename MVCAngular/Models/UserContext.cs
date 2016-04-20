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
            var results = new List<User>();
            using (_userEnt = new UserEntity())
            {
                results = _userEnt.Users.ToList();
            }

            return results;
        }

        public void  AddUser(User uData)
        {
            using (_userEnt = new UserEntity())
            {
                _userEnt.Users.Add(uData);
                _userEnt.SaveChanges();
            } 
        }


        public void Update(User data)
        {
            using (_userEnt = new UserEntity())
            {
                _userEnt.Users.Attach(data);
                _userEnt.Entry<User>(data).State = System.Data.EntityState.Modified;
                _userEnt.SaveChanges(); ;
                _userEnt.SaveChanges();
            } 
        }
    }
}