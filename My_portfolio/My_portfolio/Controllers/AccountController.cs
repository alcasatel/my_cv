using Metanit.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;

namespace Metanit.Controllers
{
    public class AccountController : Controller
    {
        UserContext db = new UserContext();
        public string Index()
        {
            string result = "Вы не авторизованы";
            if (User.Identity.IsAuthenticated)
            {
                result = "Ваш логин: " + User.Identity.Name;
            }
            return result;
        }

        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Email = User.Identity.Name;
                return View("Logoff");
            }

            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // поиск пользователя в бд
                User user = null;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Login && u.Password == model.Password);

                }
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View(model);
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

        public ActionResult UserInfo(int id = 1)
        {
            var user = db.Users.Find(id);
            return View(user);
        }

        [HttpGet]
        public ActionResult EditMainInfo(int id = 1)
        {
            var user = db.Users.Find(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult EditMainInfo(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UserInfo");
            }
            return View("user");
        }
    }
}