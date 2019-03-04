using Rent.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rent.Models;
namespace Rent.Controllers
{
    public class HomeController : Controller
    {
        private readonly RentContext context;
        public HomeController()
        {
            context = new RentContext();
        }
        public ActionResult Index()
        {

            return View(context.Rents);
        }

        public ActionResult Create()
        {
            

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Model,Marka,Price,Desc,Photo")]Rents rents)
        {
            if (!ModelState.IsValid)
            {
                return View(rents);
            }

            context.Rents.Add(rents);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));


        }
       
        public ActionResult Delete(int id)
        {
           var _id = Convert.ToInt32(id);
           var car = context.Rents.Where(c => c.Id == _id).First();
           context.Rents.Remove(car);
           context.SaveChanges();
           return RedirectToAction(nameof(Index));

            
        }
    }
}