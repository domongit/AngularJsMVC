using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCAngular.Models;
namespace MVCAngular.Controllers.Api
{
    public class HomesController : ApiController
    {
        // GET api/homes
        private UserContext _USContext;
        public IEnumerable<User> Get()
        {
            _USContext = new UserContext();
            return _USContext.GetAllUsers();
        }

        // GET api/homes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/homes
        public void Post([FromBody]string value)
        {
        }

        // PUT api/homes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/homes/5
        public void Delete(int id)
        {
        }
    }
}
