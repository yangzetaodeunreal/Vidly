using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        //index action for default home page
        public ActionResult Index()
        {
            return View();
        }

        //about action for about page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //contact action for contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}