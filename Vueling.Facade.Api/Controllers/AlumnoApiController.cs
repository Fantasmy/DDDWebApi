using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Vueling.Facade.Api.Controllers
{
    public class AlumnoApiController : ApiController
    {

        // GET: api/AlumnoApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AlumnoApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AlumnoApi
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/AlumnoApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AlumnoApi/5
        public void Delete(int id)
        {
        }
    }
}
