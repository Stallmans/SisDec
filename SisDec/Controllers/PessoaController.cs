using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisDec.Models;
using SisDec.Repository;

namespace SisDec.Controllers
{
    public class PessoaController : Controller
    {
        RepositoryPessoa repositoryPessoa = new RepositoryPessoa();
        RepositoryCidade repositoryCidade = new RepositoryCidade();

        // GET: Pessoa
        public ActionResult Listar()
        {
            return View();
        }

        // GET: Pessoa/Create
        public ActionResult ClienteFisica()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult ClienteFisica(Pessoa objPessoa  )
        {
            try
            {
                // TODO: Add insert logic here
                ViewBag.CidadeId = new SelectList(repositoryCidade.BuscarPorCidade(""), "cidadeId", "nome");
                repositoryPessoa.Inserir(objPessoa);
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
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

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
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
