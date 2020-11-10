using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst.Models;

namespace Codefirst.Controllers
{
    public class LazyloadingController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Lazyloading
        public ActionResult Index()
        {
            //Disable Lazy Loading 
            db.Configuration.LazyLoadingEnabled = false;
            var product = (from p in db.Products
                    .Include("Supplier")    //ProductModel table to be included in the result 
                           where p.ProductID == 6
                           select p).ToList();

            /*  var supplier= (from s in db.Suppliers
                    .Include("Products")    //ProductModel table to be included in the result 
                             where s.SupplierID==20
                             select s).ToList();*/

            var supplier = (from s in db.Suppliers
                   /*.Include("Products") */   //ProductModel table to be included in the result 
                            where s.SupplierID == 20
                            select s).ToList();
            return View(supplier);
        }
    }
}