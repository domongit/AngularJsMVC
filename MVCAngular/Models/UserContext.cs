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
            try
            {
                using (_userEnt = new UserEntity())
                {
                    results = _userEnt.Users.ToList();
                }
            }
            catch
            {
            }

            return results;
        }

        public void  AddUser(User uData)
        {
            try
            {
                using (_userEnt = new UserEntity())
                {
                    _userEnt.Users.Add(uData);
                    _userEnt.SaveChanges();
                }
            }
            catch { }
        }


        public void Update(User data)
        {
            try
            {
                using (_userEnt = new UserEntity())
                {
                    _userEnt.Users.Attach(data);
                    _userEnt.Entry<User>(data).State = System.Data.EntityState.Modified;
                    _userEnt.SaveChanges();
                }
            }
            catch
            { }
        }

        public void Delete(int id)
        {
            try
            {

                using (_userEnt = new UserEntity())
                {

                    var usr = _userEnt.Users.Find(id);
                    _userEnt.Users.Attach(usr);

                    _userEnt.Entry<User>(usr).State = System.Data.EntityState.Deleted;
                    _userEnt.SaveChanges(); ;

                }
            }

            catch { }
        }
    }
}