﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Produccion.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ver(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Actualizar()
        {
            return View();
        }
        public ActionResult Inventario()
        {
            return View();
        }
        public ActionResult Closets()
        {
            return View();
        }
        public ActionResult ClosetsCR()
        {
            return View();
        }
        public ActionResult Comedores()
        {
            return View();
        }
        public ActionResult Comodas()
        {
            return View();
        }
        public ActionResult ComodasCR()
        {
            return View();
        }
        public ActionResult Camas()
        {
            return View();
        }
        public ActionResult Disenno()
        {
            return View();
        }
        public ActionResult Mesas()
        {
            return View();
        }
    }
}