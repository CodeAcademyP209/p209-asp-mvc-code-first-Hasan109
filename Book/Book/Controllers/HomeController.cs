using Book.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Book.Models;

namespace Book.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookContext context;
        public HomeController()
        {
            context = new BookContext();
        }
        public ActionResult Index()
        {

            return View(context.Books);
        }

        public ActionResult Create()
        {
            

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookName,Genre,Author,Page,Photo")]Books book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            context.Books.Add(book);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(string id)
        {
            var ID = Convert.ToInt32(id);
            var _book = context.Books.Where(b => b.Id == ID).First();
            context.Books.Remove(_book);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}