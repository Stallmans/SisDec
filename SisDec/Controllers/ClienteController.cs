using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisDec.Models;
using SisDec.Repository;

namespace SisDec.Controllers
{
    public class ClienteController : Controller
    {
        RepositoryCidade repositoryCidade = new RepositoryCidade();

        public ActionResult Listar()
        {
            return View(new Cliente().BuscarTodos());
        }

        public ActionResult Inserir()
        {
            ViewBag.CidadeId = new SelectList(repositoryCidade.BuscarPorCidade(""), "cidadeId", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Cliente objCliente, string tipoPessoa, int CidadeId)
        {
            if (tipoPessoa == "fisica")
            {
                objCliente.tipoPessoa = 1;
            }
            else if (tipoPessoa == "juridica")
            
            {
                objCliente.tipoPessoa = 2;
            }

            objCliente.objCidade.CidadeId = CidadeId;
            objCliente.Gravar();
            return RedirectToAction("Listar");

        }

        // GET: Pessoa/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
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
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult Deletar(int id, FormCollection collection)
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
