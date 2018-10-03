using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            Console.Write($"UPDATE {value?.Name}");
        }        
    }
}
