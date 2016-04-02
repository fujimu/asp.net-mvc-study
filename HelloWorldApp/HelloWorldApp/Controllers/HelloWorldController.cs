using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "HELLO UC!!";
        }

        public string Welcome()
        {
            return "WeeeeelCooooooome!!";
        }

        public ActionResult YaHa()
        {
            ViewBag.OTOKO = 220;
            ViewBag.ONNA = "花子";

            return View();
        }

        public string KillerMachine(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("ここはKillerMachine:へろー" + name + "さん. numTime = " + numTimes);
        }
    }
}