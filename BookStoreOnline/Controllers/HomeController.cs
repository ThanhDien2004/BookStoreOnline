using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class HomeController : Controller
    {
        BookStoreEntities1 db = new BookStoreEntities1();
        public ActionResult Index()
        {
            var book = db.Products.ToList().Take(8);
            return View(book);
        }

        
    }
}