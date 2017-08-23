using dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web.Controllers
{
    public class HomeAPIController : ApiController
    {
        // http://localhost:62697/api/test
        [HttpGet]
        [Route("api/test")]
        public string index()
        {
            return "Hi!";
        }

        // http://localhost:62697/api/something
        [HttpGet]
        [Route("api/something")]
        public SomethingDTO something()
        {
            SomethingDTO s = new SomethingDTO();
            return s;
        }
    }
}