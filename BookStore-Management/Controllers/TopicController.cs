﻿using System;
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
    }
}