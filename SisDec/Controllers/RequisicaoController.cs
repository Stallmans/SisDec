﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisDec.Controllers
{
    public class RequisicaoController : Controller
    {
        // GET: Requisicao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Requisicao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Inserir()
        {
            return View();
        }

        // GET: Requisicao/Create
        public ActionResult Nova()
        {
            return View();
        }

        // POST: Requisicao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Requisicao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Requisicao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Requisicao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Requisicao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
