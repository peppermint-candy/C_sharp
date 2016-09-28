using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace basic
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
            // return View("Index");
            //return View("Index.cshtml");
        }




    }
}   