using Metanit.Models;
using System;
using System.Linq;
using System.Web.Mvc;



namespace Metanit.Controllers
{
    public class HomeController : Controller
    {
        public UserContext db = new UserContext();

        // GET: Home
        public ActionResult Index(int id=1)
        {
            var user = db.Users.Find(id);
            user.Educations = db.Educations.Where(m => m.UserId == id);
            user.Experiences = db.Experiences.Where(m => m.UserId == id);
            if (user == null) { return HttpNotFound(); }

            return View(user);
        }




    }
}