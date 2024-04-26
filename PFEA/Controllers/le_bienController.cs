using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PFEA.Models;

namespace PFEA.Controllers
{
    public class le_bienController : Controller
    {
        private Agence_immobilierEntities11 db = new Agence_immobilierEntities11();

        // GET: le_bien
        public ActionResult Index()
        {
            return View(db.le_bien.ToList());
        }

        // GET: le_bien/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            le_bien le_bien = db.le_bien.Find(id);
            if (le_bien == null)
            {
                return HttpNotFound();
            }
            return View(le_bien);
        }

        // GET: le_bien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: le_bien/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_bien,type_bien,superficie,description,localisation,prix,image,date_annonces")] le_bien le_bien)
        {
            if (ModelState.IsValid)
            {
                db.le_bien.Add(le_bien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(le_bien);
        }

        // GET: le_bien/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            le_bien le_bien = db.le_bien.Find(id);
            if (le_bien == null)
            {
                return HttpNotFound();
            }
            return View(le_bien);
        }

        // POST: le_bien/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bien,type_bien,superficie,description,localisation,prix,image,date_annonces")] le_bien le_bien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(le_bien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(le_bien);
        }

        // GET: le_bien/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            le_bien le_bien = db.le_bien.Find(id);
            if (le_bien == null)
            {
                return HttpNotFound();
            }
            return View(le_bien);
        }

        // POST: le_bien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            le_bien le_bien = db.le_bien.Find(id);
            db.le_bien.Remove(le_bien);
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
