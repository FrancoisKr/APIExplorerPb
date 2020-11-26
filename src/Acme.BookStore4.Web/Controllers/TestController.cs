using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.BookStore4.Web.Controllers
{
    [RemoteService(IsMetadataEnabled = false)]
    [ApiVersion("3.0")]
    [Route("v{version:apiVersion}/test/[action]")]
    [ApiController]
    //[Produces("application/json")]
    public class TestController : Controller
    {
        [Produces("text/plain")]
        //[Route("Test/a1")]
        [HttpGet]
        public async Task<string> a1()
        {
            return "Hello World";
        }

        [HttpGet]
        //[Route("Test/a3")]
        public IActionResult a3()
        {
            var result = new { field1 = "field1", field2 = "field2" };
            return Ok(result);
        }
        //[HttpGet]
        ////[Route("Test/a4")]
        //public IActionResult a4([FromHeader] string f1, [FromHeader] string f2)
        //{
        //    var result = new { field1 = f1, field2 = f2 };
        //    return Ok(result);
        //}
    }
}
