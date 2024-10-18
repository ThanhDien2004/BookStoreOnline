﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class OrderController : Controller
    {
        BookStoreEntities1 db = new BookStoreEntities1();
        // GET: Order
        public ActionResult Index(int id)
        {
            return View(db.Orders.Where(o => o.IDCus == id).ToList());
        }

        
    }
}