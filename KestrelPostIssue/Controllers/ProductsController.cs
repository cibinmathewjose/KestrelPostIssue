using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace KestrelPostIssue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       
        // POST api/values
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            Console.Write($"ADD {value?.Name}");
        }

        // PUT api/values/5
        [HttpPut]
        public void Put()
        {
            var str = new StreamReader(Request.Body).ReadToEnd();
            JObject testdata = JObject.Parse(str);
            Console.Write(testdata.ToString());
        }        
    }
}
