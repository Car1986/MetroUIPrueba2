﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult PayDocumentUser()
        {      
            return View();
        }

        public ActionResult PayDocumentClient()
        {
            return View();
        }
        public ActionResult user_client_choose()
        {
            return View();
        }

        public ActionResult product_selected()
        {
            return View();
        }
        public ActionResult Mesas()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Intranet()
        {
            return View();
        }
<<<<<<< HEAD
        public ActionResult Disenno()
=======

        public ActionResult Vision()
        {
            return View();
        }

        public ActionResult Mission()
>>>>>>> f0bd5fec584beb38a67184a4999b3c7f8ff1f379
        {
            return View();
        }
    }
}