using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace manders_api.Controllers
{
    public class IndexController : ApiController {
        [HttpGet]
        public IHttpActionResult Test() {
            return Ok("suh");
        }
    }
}
