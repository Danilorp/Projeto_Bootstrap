using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            if (ModelState.IsValid)
            {
                db.Funcionarios.Add(func);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(func);
        }
        #endregion

        #region - Details
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
        #endregion

        #region Edit - Get
        [HttpGet]
        public ActionResult Edit(int? id)
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
        #endregion

        #region Edit - Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit (funcionarioModel func)
        {
            if (ModelState.IsValid)
            {
                db.Entry(func).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(func);
        }
        #endregion

        #region  Delete - Get
        [HttpGet]

        public ActionResult Delete(int? id)
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
        #endregion

        #region Delete - Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            funcionarioModel func = db.Funcionarios.Find(id);
            db.Funcionarios.Remove(func);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
    }
}