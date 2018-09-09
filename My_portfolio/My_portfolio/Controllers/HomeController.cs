using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Metanit.Models;
using Metanit.Util;

namespace Metanit.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;

            ViewBag.Books = books;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;

            db.Purchases.Add(purchase);
            db.SaveChanges();

            return "Спасибо," + purchase.Person + ", за покупку!";
        }

        private DateTime GetToday()
        {
            return DateTime.Now;
        }

        public string Square(int a, int h)
        {
            double s = a * h / 2.0;
            return "<h2>Площадь треугольника с основанием " + a +
                    " и высотой " + h + " равна " + s + "</h2>";
        }

        public string Square()
        {
            int a = Int32.Parse(Request.Params["a"]);
            int h = Int32.Parse(Request.Params["h"]);
            double s = a * h / 2.0;
            return "<h2>Площадь треугольника с основанием " + a + " и высотой " + h + " равна " + s + "</h2>";
        }

        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }

        public ActionResult GetImage()
        {
            string path = "../Content/Images/visualstudio.png";
            return new ImageResult(path);
        }

        public RedirectResult SomeMethod()
        {
            return Redirect("/Home/Index");
        }

        public ActionResult Partial()
        {
            ViewBag.Message = "Это частичное представление";
            return PartialView();
        }

        public ActionResult BookView(int? id)
        {
            var book = db.Books.Find(id);

            if (id == null)
            {
                return HttpNotFound();
            }

            if (book != null )
            {
                return View(book);
            }

            return RedirectToAction("Index");
            
        }

        [HttpGet]
        public ActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Book book = db.Books.Find(id);

            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            db.Entry(book).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            db.Books.Add(book);

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book b = db.Books.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book b = db.Books.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Books.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}