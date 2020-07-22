using manders_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace manders_api.Controllers
{
    public class ScheduleController : ApiController
    {
        private readonly ScheduleService service = new ScheduleService();

        [HttpGet]
        public IHttpActionResult Day(int year, int month, int day) {
            return Ok(service.GetForDate(new DateTime(year, month + 1, day)));
        }
    }
}
