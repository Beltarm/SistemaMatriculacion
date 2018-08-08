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
    public class NOTAController : Controller
    {
        private Sistema_matriculacionEntities db = new Sistema_matriculacionEntities();

        // GET: NOTA
        public ActionResult Index()
        {
            var nOTA = db.NOTA.Include(n => n.ESTUDIANTE).Include(n => n.MATERIA);
            return View(nOTA.ToList());
        }

        // GET: NOTA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOTA nOTA = db.NOTA.Find(id);
            if (nOTA == null)
            {
                return HttpNotFound();
            }
            return View(nOTA);
        }

        // GET: NOTA/Create
        public ActionResult Create()
        {
            ViewBag.ID_ESTUDIANTE = new SelectList(db.ESTUDIANTE, "ID_ESTUDIANTE", "NOMBRE_ESTUDIANTE");
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA");
            return View();
        }

        // POST: NOTA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ESTUDIANTE,ID_MATERIA,CALIFICACION")] NOTA nOTA)
        {
            if (ModelState.IsValid)
            {
                db.NOTA.Add(nOTA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ESTUDIANTE = new SelectList(db.ESTUDIANTE, "ID_ESTUDIANTE", "NOMBRE_ESTUDIANTE", nOTA.ID_ESTUDIANTE);
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA", nOTA.ID_MATERIA);
            return View(nOTA);
        }

        // GET: NOTA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOTA nOTA = db.NOTA.Find(id);
            if (nOTA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ESTUDIANTE = new SelectList(db.ESTUDIANTE, "ID_ESTUDIANTE", "NOMBRE_ESTUDIANTE", nOTA.ID_ESTUDIANTE);
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA", nOTA.ID_MATERIA);
            return View(nOTA);
        }

        // POST: NOTA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ESTUDIANTE,ID_MATERIA,CALIFICACION")] NOTA nOTA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nOTA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ESTUDIANTE = new SelectList(db.ESTUDIANTE, "ID_ESTUDIANTE", "NOMBRE_ESTUDIANTE", nOTA.ID_ESTUDIANTE);
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA", nOTA.ID_MATERIA);
            return View(nOTA);
        }

        // GET: NOTA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOTA nOTA = db.NOTA.Find(id);
            if (nOTA == null)
            {
                return HttpNotFound();
            }
            return View(nOTA);
        }

        // POST: NOTA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NOTA nOTA = db.NOTA.Find(id);
            db.NOTA.Remove(nOTA);
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
