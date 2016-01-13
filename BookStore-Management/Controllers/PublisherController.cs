using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore_Management.Models;

namespace BookStore_Management.Controllers
{
    public class PublisherController : Controller
    {
        // Create Database
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();

        // GET: Publisher
        public PartialViewResult PublisherPartial()
        {
            return PartialView(db.NhaXuatBans.Take(10).ToList());
        }
    }
}