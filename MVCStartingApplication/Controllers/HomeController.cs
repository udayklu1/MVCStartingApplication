using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStartingApplication.Controllers
{
    public class HomeController : Controller
    {

        [HandleError(View = "MyError", ExceptionType = typeof(StackOverflowException))]
        public ActionResult Index()
        {
           return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }
        //[Authorize]
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks, we got your message!";
            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }
        [Route("Home/serial")]
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5LEARNING";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);
            return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
        }
    }
}