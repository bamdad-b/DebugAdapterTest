using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace TGSNG.API.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
