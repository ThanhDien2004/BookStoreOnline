using BookStoreOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreOnline.Areas.Admin.Controllers
{
    public class RevenueController : Controller
    {
        private BookStoreEntities1 db = new BookStoreEntities1();
        // GET: Admin/Revenue
        public ActionResult Index()
        {
            return View();
        }
    }
}