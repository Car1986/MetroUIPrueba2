﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewUser()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Modificate()
        {
            return View();
        }

    }
}