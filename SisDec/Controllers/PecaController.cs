using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisDec.Controllers
{
    public class PecaController : Controller
    {
        // GET: Peca
        public ActionResult Index()
        {
            return View();
        }

        // GET: Peca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Peca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peca/Create
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

        // GET: Peca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Peca/Edit/5
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

        // GET: Peca/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Peca/Delete/5
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
