using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore_Management.Models;

namespace BookStore_Management.Controllers
{
    public class BookController : Controller
    {
        // Create a Database
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();

        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult NewBooksPartial()
        {
            var listNewBooks = db.Saches.Take(3).ToList();
            return PartialView(listNewBooks);
        }
    }
}