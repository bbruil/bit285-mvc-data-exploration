using MVC_DataExploration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        MyDBContext db = new MyDBContext();
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {  
            return View(db.Products);
        }
        [HttpPost]
            public ActionResult Index(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return View(db.Products);

        }
    }
}