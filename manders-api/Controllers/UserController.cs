using manders_api.Models;
using manders_api.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace manders_api.Controllers
{
    public class UserController : ApiController
    {
        private readonly AuthService auth = new AuthService();

        [HttpPost]
        public IHttpActionResult Register([FromBody] User user) {
            return Ok(auth.ValidateRegister(user));
        }

        [HttpPost]
        public IHttpActionResult Login([FromBody] Login login) {
            return Ok(auth.ValidateLogin(login));
        }
    }
}
