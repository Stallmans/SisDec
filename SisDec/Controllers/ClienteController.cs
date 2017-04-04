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

        public  ActionResult DetalhesClienteFisica(int idCliente)
        {
            return View(new Cliente().BuscarPorId(idCliente));
        }

        public ActionResult Inserir()
        {
            ViewBag.CidadeId = new SelectList(new Cidade().BuscarPorNome(""), "cidadeId", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Cliente objCliente, TipoPessoa tipoPessoa, int CidadeId)
        {
            
            objCliente.tipoPessoa = tipoPessoa;
            objCliente.objCidade = new Cidade().BuscarPorId(CidadeId);
            objCliente.Gravar();
            return RedirectToAction("Index");

        }

        public ActionResult EditarClienteFisica(Cliente objCliente, int CidadeId)
        {
            objCliente.objCidade = new Cidade().BuscarPorId(CidadeId);
            objCliente.Gravar();
            return View();
        }

        [HttpPost]
        public ActionResult EditarClienteFisica(Cliente objCliente)
        {
            objCliente.Gravar();
            return RedirectToAction("Listar");
        }
    }
}
