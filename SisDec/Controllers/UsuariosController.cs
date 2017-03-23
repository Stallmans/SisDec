using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisDec.Repository;
using SisDec.Models;

namespace SisDec.Controllers
{
    public class UsuariosController : Controller
    {

        RepositoryUsuario repositoryUsuario = new RepositoryUsuario();

        public ActionResult Listar()
        {
            return View(repositoryUsuario.BuscarTodos());
        }

        
        // GET: Usuarios/Create
        public ActionResult Inserir()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Usuarios objUsuario)
        {
            repositoryUsuario.Inserir(objUsuario);
            return RedirectToAction("Listar");
           
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
           
                return RedirectToAction("Index");
            
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
