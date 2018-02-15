using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotEngine.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("BotApi/[controller]")]
    public class BotQueriesController : Controller
    {
        // GET api/values/5
        [HttpGet("{botToken}/{queryName}/{parameters}")]
        public string Execute(string botToken, string queryName, string parameters)
        {
            return "value";
        }
    }
}