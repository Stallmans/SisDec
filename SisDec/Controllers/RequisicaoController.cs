using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisDec.Controllers
{
    public class RequisicaoController : Controller
    {
        // GET: Requisicao
        public ActionResult Listar()
        {
            return View();
        }


        // GET: Requisicao/Inserir
        public ActionResult Inserir()
        {
            return View();
        }


        // POST: Requisicao/Inserir
        [HttpPost]
        public ActionResult Inserir(FormCollection form)
        {

            return View();
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

    }
}
