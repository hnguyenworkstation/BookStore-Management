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

        // Get the action of "click to view more" or "View Details"
        public ViewResult viewDetails(int BookID)
        {
            Sach book = db.Saches.SingleOrDefault(n => n.MaSach == BookID);
            if(book == null)
            {
                //Return Error Page -- 404 Error
                Response.StatusCode = 404;
                return null;
            }
            return View(book);
        }
    }
}