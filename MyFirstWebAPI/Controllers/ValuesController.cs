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

        // Get GetData/1234/Provider/Query
        [HttpGet("{key}/{SpatialOperationSource}/Query")]
        public string GetQuery(string key, string SpatialOperationSource)
        {
            return "Key: " + key + " , SpatialOperationSource: " + SpatialOperationSource; 
        }
        
    }
}
