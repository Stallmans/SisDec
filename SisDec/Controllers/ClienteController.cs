using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisDec.Models;


namespace SisDec.Controllers
{
    public class ClienteController : Controller
    {


        public ActionResult Listar()
        {
            return View(new Cliente().BuscarTodos());
        }

        public ActionResult DetalhesClienteFisica(int idCliente)
        {
            return View(new Cliente().BuscarPorIdF(idCliente));
        }

        public ActionResult DetalhesClienteJuridica(int idCliente)
        {
            return View(new Cliente().BuscarPorIdJ(idCliente));
        }

        public ActionResult Inserir()
        {
            ViewBag.CidadeId = new SelectList(new Cidade().BuscarPorNome(""), "cidadeId", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Cliente objCliente, TipoPessoa tipoPessoa, int CidadeId)
        {
            if (ModelState.IsValid)
            {

                objCliente.tipoPessoa = tipoPessoa;
                objCliente.objCidade = new Cidade().BuscarPorId(CidadeId);
                objCliente.Gravar();
            }
                return RedirectToAction("Listar");
            
        }

        public ActionResult EditarClienteFisica(Cliente objCliente, int IdCliente)
        {
            ViewBag.CidadeId = new SelectList(new Cidade().BuscarPorNome(""), "cidadeId", "nome");
            objCliente = new Cliente().BuscarPorIdF(IdCliente);
            return View(objCliente);
        }

        [HttpPost]
        public ActionResult EditarClienteFisica(Cliente objCliente)
        {
            if (ModelState.IsValid)
            {
                objCliente.Gravar();
            }
            return RedirectToAction("Listar");
        }

        public ActionResult EditarClienteJuridica(Cliente objCliente, int IdCliente)
        {
            ViewBag.CidadeId = new SelectList(new Cidade().BuscarPorNome(""), "cidadeId", "nome");
            objCliente = new Cliente().BuscarPorIdJ(IdCliente);
            return View(objCliente);
        }

        [HttpPost]
        public ActionResult EditarClienteJuridica(Cliente objCliente)
        {
            if (ModelState.IsValid)
            {
                objCliente.Gravar();
            }
            return RedirectToAction("Listar");
        }
    }
}
