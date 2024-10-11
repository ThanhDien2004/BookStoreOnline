﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class CategoryPartialController : Controller
    {
        BookStoreEntities1 db = new BookStoreEntities1();
        // GET: CategoryPartial
        public ActionResult GetPartialCategoryNav()
        {
            ViewBag.CateList = db.Categories.ToList();
            return PartialView();
        }

        public ActionResult GetCategorySelection()
        {
            ViewBag.CateList = db.Categories.ToList();
            return PartialView();
        }
    }
}