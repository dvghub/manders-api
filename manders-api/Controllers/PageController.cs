using manders_api.Models;
using manders_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace manders_api.Controllers 
    {
    public class PageController : ApiController 
        {
        private readonly PageService pageService = new PageService();

        [HttpGet]
        public IHttpActionResult Read(string page) {
            return Ok(pageService.Read(page));
        }

        [HttpPost]
        public IHttpActionResult Update([FromBody] PageContent pageContent) {
            return Ok(pageService.Update(pageContent));
        }
    }
}