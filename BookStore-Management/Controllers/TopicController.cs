using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore_Management.Models;

namespace BookStore_Management.Controllers
{
    public class TopicController : Controller
    {
        // Add Local Database
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();

        // GET: Topic
        public PartialViewResult TopicPartial()
        {
            return PartialView(db.ChuDes.Take(5).ToList());
        }

        /*Find books by Topic*/
        public ViewResult booksByTopic(int topicID)
        {
            // Check if the topic ID is valid
            ChuDe topic = db.ChuDes.SingleOrDefault(n => n.MaChuDe == topicID);
            if(topic == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            // Get list of books by topic
            List<Sach> lstBook = db.Saches.Where(n => n.MaChuDe == topicID).OrderBy(n=>n.GiaBan).ToList();

            if(lstBook.Count == 0)
            {
                ViewBag.Sach = "Couldn't Find any book matches this topic";
            }
            return View(lstBook);

        }
    }
}