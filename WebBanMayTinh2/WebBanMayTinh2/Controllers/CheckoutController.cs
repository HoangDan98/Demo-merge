﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanMayTinh2.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            return View("Checkout");
        }
    }
}