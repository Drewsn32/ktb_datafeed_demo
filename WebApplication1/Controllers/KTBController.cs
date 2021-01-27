using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    [Route("v1/[controller]")]
    [ApiController]
    public class KTBController : Controller
    {
        [HttpGet]
        [Route("DataFeed")]
        public IActionResult GetDataFeed([FromBody]object model)
        {
            return Ok("OK");
        }
    }
}
