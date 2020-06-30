using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace manders_api.Controllers
{
    public class AppointmentController : ApiController
    {
        [HttpGet]
        public IHttpActionResult All() {
            return null;
        }
    }
}
