using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Metanit.Controllers
{
    public class HomeController : Controller
    {
        public string Name = "Грошев Александр";
        public string Vocation = "";
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = Name;
            ViewBag.Vocation = Vocation;
            return View();
        }

       
    }
}