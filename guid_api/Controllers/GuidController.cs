using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using guid_api.Models;

namespace guid_api.Controllers
{
    [RoutePrefix("api/guids")]
    public class GuidController : ApiController
    {
        [Route("new")]
        [HttpGet]
        // GET api/values
        public GuidResponse Get()
        {            
            Guid g = Guid.NewGuid();
            return new GuidResponse { Guid = g.ToString() };
        }
    }
}