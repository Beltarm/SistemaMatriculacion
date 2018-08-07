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
    public class MATERIAController : Controller
    {
        private Sistema_matriculacionEntities1 db = new Sistema_matriculacionEntities1();

        // GET: MATERIA
        public ActionResult Index()
        {
            return View(db.MATERIA.ToList());
        }

        // GET: MATERIA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATERIA mATERIA = db.MATERIA.Find(id);
            if (mATERIA == null)
            {
                return HttpNotFound();
            }
            return View(mATERIA);
        }

        // GET: MATERIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MATERIA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MATERIA,NOMBRE_MATERIA")] MATERIA mATERIA)
        {
            if (ModelState.IsValid)
            {
                db.MATERIA.Add(mATERIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mATERIA);
        }

        // GET: MATERIA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATERIA mATERIA = db.MATERIA.Find(id);
            if (mATERIA == null)
            {
                return HttpNotFound();
            }
            return View(mATERIA);
        }

        // POST: MATERIA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MATERIA,NOMBRE_MATERIA")] MATERIA mATERIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mATERIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mATERIA);
        }

        // GET: MATERIA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATERIA mATERIA = db.MATERIA.Find(id);
            if (mATERIA == null)
            {
                return HttpNotFound();
            }
            return View(mATERIA);
        }

        // POST: MATERIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MATERIA mATERIA = db.MATERIA.Find(id);
            db.MATERIA.Remove(mATERIA);
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
