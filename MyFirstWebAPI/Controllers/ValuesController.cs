using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAPI.Controllers
{
    [Route("GetData")]
    public class ValuesController : Controller
    {
        // Get GetData/GetHelloWorld
        [HttpGet]
        public string GetHelloWorld()
        {
            return "Hello World";
        }

        // Get GetData/
        [HttpGet("{key}")]
        public string GetQuery(string key)
        {
            // statements to  process the supplied keys
            return "Key: " + key  ; 
        }
        
    }
}
