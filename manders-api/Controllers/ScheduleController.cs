using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace manders_api.Controllers
{
    public class ScheduleController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Current() {
            return null;
        }
    }
}
