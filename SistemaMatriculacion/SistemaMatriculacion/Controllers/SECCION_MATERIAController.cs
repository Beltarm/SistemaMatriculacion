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
    public class SECCION_MATERIAController : Controller
    {
        private Sistema_matriculacionEntities db = new Sistema_matriculacionEntities();

        // GET: SECCION_MATERIA
        public ActionResult Index()
        {
            var sECCION_MATERIA = db.SECCION_MATERIA.Include(s => s.MATERIA).Include(s => s.PROFESOR).Include(s => s.SECCION);
            return View(sECCION_MATERIA.ToList());
        }

        // GET: SECCION_MATERIA/Details/5
        public ActionResult Details(int? id1, int? id2)
        {
            if (id1 == null || id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECCION_MATERIA sECCION_MATERIA = db.SECCION_MATERIA.Find(id1, id2);
            if (sECCION_MATERIA == null)
            {
                return HttpNotFound();
            }
            return View(sECCION_MATERIA);
        }

        // GET: SECCION_MATERIA/Create
        public ActionResult Create()
        {
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA");
            ViewBag.ID_PROFESOR = new SelectList(db.PROFESOR, "ID_PROFESOR", "NOMBRE_PROFESOR");
            ViewBag.ID_SECCION = new SelectList(db.SECCION, "ID_SECCION", "NOMBRE_SECCION");


            //var SeccionLst = new List<string>();
            //var SeccionQry = from d in db.SECCION
            //               orderby d.NOMBRE_SECCION
            //               select d.ID_SECCION + " - " + d.NOMBRE_SECCION;

            //SeccionLst.AddRange(SeccionQry.Distinct());
            //ViewBag.vbNombreSeccion = new SelectList(SeccionLst);





            return View();
        }

        // POST: SECCION_MATERIA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SECCION,ID_MATERIA,ID_PROFESOR,HORARIO")] SECCION_MATERIA sECCION_MATERIA)
        {

            ViewResult retorno = View();
            try
            {
                if (ModelState.IsValid)
                {

                    db.SECCION_MATERIA.Add(sECCION_MATERIA);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA", sECCION_MATERIA.ID_MATERIA);
                ViewBag.ID_PROFESOR = new SelectList(db.PROFESOR, "ID_PROFESOR", "NOMBRE_PROFESOR", sECCION_MATERIA.ID_PROFESOR);
                ViewBag.ID_SECCION = new SelectList(db.SECCION, "ID_SECCION", "NOMBRE_SECCION", sECCION_MATERIA.ID_SECCION);
                retorno = View(sECCION_MATERIA);

            }

            catch (System.Exception excep) when (excep.HResult == -2146233087)
            {
                ViewBag.Error = 1;
                ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA");
                ViewBag.ID_PROFESOR = new SelectList(db.PROFESOR, "ID_PROFESOR", "NOMBRE_PROFESOR");
                ViewBag.ID_SECCION = new SelectList(db.SECCION, "ID_SECCION", "NOMBRE_SECCION");
                return View(sECCION_MATERIA);

            }
            return retorno;
        }

        // GET: SECCION_MATERIA/Edit/5
        public ActionResult Edit(int? id1, int? id2)
        {
            if (id1 == null || id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECCION_MATERIA sECCION_MATERIA = db.SECCION_MATERIA.Find(id1, id2);
            if (sECCION_MATERIA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA", sECCION_MATERIA.ID_MATERIA);
            ViewBag.ID_PROFESOR = new SelectList(db.PROFESOR, "ID_PROFESOR", "NOMBRE_PROFESOR", sECCION_MATERIA.ID_PROFESOR);
            ViewBag.ID_SECCION = new SelectList(db.SECCION, "ID_SECCION", "NOMBRE_SECCION", sECCION_MATERIA.ID_SECCION);
            return View(sECCION_MATERIA);
        }

        // POST: SECCION_MATERIA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SECCION,ID_MATERIA,ID_PROFESOR,HORARIO")] SECCION_MATERIA sECCION_MATERIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sECCION_MATERIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MATERIA = new SelectList(db.MATERIA, "ID_MATERIA", "NOMBRE_MATERIA", sECCION_MATERIA.ID_MATERIA);
            ViewBag.ID_PROFESOR = new SelectList(db.PROFESOR, "ID_PROFESOR", "NOMBRE_PROFESOR", sECCION_MATERIA.ID_PROFESOR);
            ViewBag.ID_SECCION = new SelectList(db.SECCION, "ID_SECCION", "NOMBRE_SECCION", sECCION_MATERIA.ID_SECCION);
            return View(sECCION_MATERIA);
        }

        // GET: SECCION_MATERIA/Delete/5
        public ActionResult Delete(int? id1, int? id2)
        {
            if (id1 == null || id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SECCION_MATERIA sECCION_MATERIA = db.SECCION_MATERIA.Find(id1, id2);
            if (sECCION_MATERIA == null)
            {
                return HttpNotFound();
            }
            return View(sECCION_MATERIA);
        }

        // POST: SECCION_MATERIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id1, int id2)
        {
            SECCION_MATERIA sECCION_MATERIA = db.SECCION_MATERIA.Find(id1, id2);
            db.SECCION_MATERIA.Remove(sECCION_MATERIA);
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
