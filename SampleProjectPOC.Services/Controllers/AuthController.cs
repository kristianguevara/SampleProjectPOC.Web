using SampleProjectPOC.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleProjectPOC.Services.Controllers
{
    [RoutePrefix("api")]
    [EnableCors(origins: "http://localhost:2783", headers: "*", methods: "*")]
    public class AuthController : ApiController
    {
        
        [Route("login")]
        [HttpPost]
        public string login([FromBody] Users login)
        {
            if(ModelState.IsValid)
            {
                using(var db = new MainContext())
                {
                    var query = db.Users.Where(x => x.username == login.username);
                    var lists = query.ToList();
                    if (lists.Count == 0) { return "Username or password doesn\'t exist!";  }
                }
            }
            return "Successfully logged in";
        }

        [Route("list")]
        [HttpPost]
        public List<Users> login([FromBody] Users login)
        {
            List<Users> lists = new List<Users>();
            if (ModelState.IsValid)
            {
                using (var db = new MainContext())
                {
                    var query = db.Users.ToList();
                    lists = query.ToList();
                    if (lists.Count == 0) { string test =  "No rows"; }
                }
            }
            return lists;
        }
    }
}
