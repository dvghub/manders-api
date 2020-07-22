using manders_api.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace manders_api.Controllers
{
    public class AppointmentController : ApiController
    {
        private readonly AppointmentService service = new AppointmentService();

        [HttpGet]
        public IHttpActionResult All() {
            return null;
        }
    }
}
