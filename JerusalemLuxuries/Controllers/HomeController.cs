using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JerusalemLuxuryDomain.Models;
using JerusalemLuxuryDomain.DataSource;
using JerusalemLuxuries.Models;


namespace JerusalemLuxuries.Controllers
{
    //I'm trying to change the comment
    //change comment
    public class HomeController : Controller
    {
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}