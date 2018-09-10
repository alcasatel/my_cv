using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Metanit.Controllers
{
    public class HomeController : Controller
    {
        public string name = "Грошев Александр";
        public string vocation = "Junior программист C#";
        public int age = 25;
        public string email = "alcasatel@gmail.com";
        public string adress = "Волгоград, центральный район";
        public string phone = "8 995 429 36 69";
        public string languages = "Русский родной, Английский свободный, латышский средний";
        public string about = "<p>Euismod massa scelerisque suspendisse fermentum habitant vitae ullamcorper magna quam iaculis, tristique sapien taciti mollis interdum sagittis libero nunc inceptos tellus, hendrerit vel eleifend primis lectus quisque cubilia sed mauris.</p> ";

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = name;
            ViewBag.vocation = vocation;
            ViewBag.age = age;
            ViewBag.email = email;
            ViewBag.adress = adress;
            ViewBag.phone = phone;
            ViewBag.lang = languages;
            ViewBag.about = about;
            return View();
        }

       
    }
}