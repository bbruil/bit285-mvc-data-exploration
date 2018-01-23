﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        [HttpPost]
        public ActionResult Create()
        {
            Customer customer = new Customer();
            db.Customers.Add(customer);
            db.SaveChanges();
            return View("Index", db.Customers); 

        }
    

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers);
        }
    }
}