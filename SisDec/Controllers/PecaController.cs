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

        // Listar
        public ActionResult listar()
        {
            return View(new Peca().BuscarTodos());
        }


        // GET
        public ActionResult Inserir()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Inserir(Peca objPeca)
        {
            if (ModelState.IsValid)
            {
                objPeca.Gravar();
            }
            return RedirectToAction("Listar");

        }

        // GET
        public ActionResult Editar(int PecaId)
        {
            RepositoryPeca repositoryPeca = new RepositoryPeca();
            Peca peca = repositoryPeca.BuscarPorId(PecaId);

            return View(peca);
        }

        // POST
        [HttpPost]
        public ActionResult Editar(Peca objPeca)
        {
            if (ModelState.IsValid)
            {
                objPeca.Gravar();
            }
            return RedirectToAction("Listar");
        }
    }
}
