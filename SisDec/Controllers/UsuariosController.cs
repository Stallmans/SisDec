using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisDec.Models;

namespace SisDec.Controllers
{
    public class UsuariosController : Controller
    {


        public ActionResult Listar()
        {
            return View(new Usuarios().BuscarTodos());
        }


        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Usuarios objUsuario)
        {
            objUsuario.Gravar();
            return RedirectToAction("Listar");

        }

        public ActionResult Editar(Usuarios objUsuario, int idUsuario)
        {
            objUsuario = new Usuarios().BuscarPorId(idUsuario);
            return View(objUsuario);
        }

        [HttpPost]
        public ActionResult Editar(Usuarios objUsuario)
        {
            objUsuario.Gravar();
            return RedirectToAction("Listar");

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection f)
        {

            if (f["Login"] == "igor" && f["Senha"] == "123123")
            {
                return RedirectToAction("Listar");
            }
            else
            {
                ViewBag.Erro = "Erro de Autenticação";
            }
            return View("Login");
        }


    }
}
