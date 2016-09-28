using Microsoft.AspNetCore.Mvc;
namespace surveyform
{
    public class SurveyFormController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string loc, string lan, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = loc;
            ViewBag.language = lan;
            ViewBag.comment = comment;
            return View();
        }
    }
}