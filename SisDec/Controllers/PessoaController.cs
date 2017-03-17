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
        RepositoryClienteFisica repositoryClienteFisica = new RepositoryClienteFisica();
        RepositoryClienteJuridica repositoryClienteJuridica = new RepositoryClienteJuridica();
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
        public ActionResult ClienteFisica(PessoaFisica objPessoaFisica)
        {
            try
            {
                // TODO: Add insert logic here
                ViewBag.CidadeId = new SelectList(repositoryCidade.BuscarPorCidade(""), "cidadeId", "nome");
                repositoryClienteFisica.Inserir(objPessoaFisica);
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult EditarPessoaFisica(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult EditarPessoaFisica(int id, FormCollection collection)
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
        public ActionResult DeletarPessoaFisica(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult DeletarPessoaFisica(int id, FormCollection collection)
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


        // -------------------Pessoa juridica----------------------//

        public ActionResult ClienteJuridica()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult ClienteJuridica(PessoaJuridica objPessoaJuridica)
        {
            try
            {
                // TODO: Add insert logic here
                ViewBag.CidadeId = new SelectList(repositoryCidade.BuscarPorCidade(""), "cidadeId", "nome");
                repositoryClienteJuridica.Inserir(objPessoaJuridica);
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult EditarPessoaJuridica(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult EditarPessoaJuridica(int id, FormCollection collection)
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
        public ActionResult DeletarPessoaJuridica(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult DeletarPessoaJuridica(int id, FormCollection collection)
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
