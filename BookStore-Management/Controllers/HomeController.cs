using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore_Management.Models;

namespace BookStore_Management.Controllers
{
    public class HomeController : Controller
    {
        // Declare Database
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Saches.Where(x=>x.Moi == 1).ToList());
        }

    }
}