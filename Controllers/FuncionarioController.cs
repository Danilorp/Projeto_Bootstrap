using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TemplateBootstrap.Context;
using TemplateBootstrap.Models;

namespace TemplateBootstrap.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Funcionario

        #region Index
        public ActionResult Index()
        {
            return View(db.Funcionarios.ToList());
        }
        #endregion

        #region Create - GET
        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }
        #endregion

        #region Create - POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(funcionarioModel func)
        {
            if(ModelState.IsValid)
            {
                db.Funcionarios.Add(func);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        [HttpGet]

        public ActionResult Details (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            funcionarioModel func = db.Funcionarios.Find(id);

            if (func == null)
            {
                return HttpNotFound();
            }

            return View(func);
        }
    }
}