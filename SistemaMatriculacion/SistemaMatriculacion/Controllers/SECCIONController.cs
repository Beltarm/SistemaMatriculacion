using System;
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
    public class SECCIONController : Controller
    {
        private Sistema_matriculacionEntities db = new Sistema_matriculacionEntities();

        // GET: SECCION
        public ActionResult Index()
        {
            return View(db.SECCION.ToList());
        }

        // GET: SECCION/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECCION sECCION = db.SECCION.Find(id);
            if (sECCION == null)
            {
                return HttpNotFound();
            }
            return View(sECCION);
        }

        // GET: SECCION/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SECCION/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SECCION,NOMBRE_SECCION,CANTIDAD_ESTUDIANTES,HORARIO")] SECCION sECCION)
        {
            if (ModelState.IsValid)
            {
                db.SECCION.Add(sECCION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sECCION);
        }

        // GET: SECCION/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECCION sECCION = db.SECCION.Find(id);
            if (sECCION == null)
            {
                return HttpNotFound();
            }
            return View(sECCION);
        }

        // POST: SECCION/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SECCION,NOMBRE_SECCION,CANTIDAD_ESTUDIANTES,HORARIO")] SECCION sECCION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sECCION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sECCION);
        }

        // GET: SECCION/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECCION sECCION = db.SECCION.Find(id);
            if (sECCION == null)
            {
                return HttpNotFound();
            }
            return View(sECCION);
        }

        // POST: SECCION/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SECCION sECCION = db.SECCION.Find(id);
            db.SECCION.Remove(sECCION);
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
