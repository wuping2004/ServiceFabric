using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Produces("application/json")]
    public class APIsController : Controller
    {
        // GET: api/APIs
        [HttpGet]
        public string Get()
        {
            return "Hello world!";
        }

   
        // POST: api/APIs
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/APIs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
