﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using btap.Models;

namespace btap.Controllers
{
    public class AppleController : Controller
    {
        bc_webEntities db = new bc_webEntities();
        // GET: Iphone
        public ActionResult Index()
        {
            return View(db.thongtinmathangs.ToList());
        }

    }
}