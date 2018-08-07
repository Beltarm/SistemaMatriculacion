﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaMatriculacion.Models;

namespace SistemaMatriculacion.Controllers
{
    public class ESTUDIANTEController : Controller
    {
        private Sistema_matriculacionEntities2 db = new Sistema_matriculacionEntities2();

        // GET: ESTUDIANTE
        public ActionResult Index()
        {
            return View(db.ESTUDIANTE.ToList());
        }

        [Authorize(Roles = "estudiante")]
        // GET: ESTUDIANTE/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTE.Find(id);
            if (eSTUDIANTE == null)
            {
                return HttpNotFound();
            }
            return View(eSTUDIANTE);
        }

        // GET: ESTUDIANTE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ESTUDIANTE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MATRICULA,NOMBRE_ESTUDIANTE,APELLIDO_ESTUDIANTE,FECHA_NACIMIENTO_ESTUDIANTE,SEXO_ESTUDIANTE,DIRECCION_ESTUDIANTE")] ESTUDIANTE eSTUDIANTE)
        {
            if (ModelState.IsValid)
            {
                db.ESTUDIANTE.Add(eSTUDIANTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eSTUDIANTE);
        }

        // GET: ESTUDIANTE/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTE.Find(id);
            if (eSTUDIANTE == null)
            {
                return HttpNotFound();
            }
            return View(eSTUDIANTE);
        }

        // POST: ESTUDIANTE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MATRICULA,NOMBRE_ESTUDIANTE,APELLIDO_ESTUDIANTE,FECHA_NACIMIENTO_ESTUDIANTE,SEXO_ESTUDIANTE,DIRECCION_ESTUDIANTE")] ESTUDIANTE eSTUDIANTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eSTUDIANTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eSTUDIANTE);
        }

        // GET: ESTUDIANTE/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTE.Find(id);
            if (eSTUDIANTE == null)
            {
                return HttpNotFound();
            }
            return View(eSTUDIANTE);
        }

        // POST: ESTUDIANTE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTE.Find(id);
            db.ESTUDIANTE.Remove(eSTUDIANTE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
