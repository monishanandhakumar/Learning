using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst.Models;

namespace Codefirst.Controllers
{
    public class CarsController : Controller
    {
        VechilesContext db = new VechilesContext();
        Car c = new Car();
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(c);
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            db.cars.Add(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}