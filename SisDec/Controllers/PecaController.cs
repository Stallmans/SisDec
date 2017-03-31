using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisDec.Repository;
using SisDec.Models;

namespace SisDec.Controllers
{
    public class PecaController : Controller
    {
        RepositoryPeca repositoryPeca = new RepositoryPeca();

        // GET: Peca
        public ActionResult listar()
        {
            return View(repositoryPeca.BuscarTodos());
        }


        // GET: Peca/Create
        public ActionResult Inserir()
        {
            return View();
        }

        // POST: Peca/Create
        [HttpPost]
        public ActionResult Inserir(Peca objPeca)
        {

            repositoryPeca.Inserir(objPeca);
            return RedirectToAction("Listar");

        }

        // GET: Peca/Edit/5
        public ActionResult Editar(int PecaId)
        {
            Peca peca = repositoryPeca.BuscarPorId(PecaId);
            return View(peca);
        }

        // POST: Peca/Edit/5
        [HttpPost]
        public ActionResult Editar(Peca objPeca)
        {
            repositoryPeca.Update(objPeca);
            return RedirectToAction("Listar");
        }
    }
}
