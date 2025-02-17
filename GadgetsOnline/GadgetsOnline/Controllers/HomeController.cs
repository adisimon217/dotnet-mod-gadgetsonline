﻿using GadgetsOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GadgetsOnline.Controllers
{
    public class HomeController : Controller
    {
        Inventory inventory;        

        public ActionResult Index()
        {            
            inventory = new Inventory();
            var products = inventory.GetBestSellers(6);
            System.Diagnostics.Trace.TraceInformation("[{0}]: Home Controller Index returned", DateTime.UtcNow.ToString());
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}