using manders_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace manders_api.Controllers
{
    public class SlotController : ApiController
    {
        private readonly SlotService service = new SlotService();

        [HttpGet]
        public IHttpActionResult Get(int id) {
            return Ok(service.Get(id));
        }
    }
}
