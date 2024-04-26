using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PFEA.Models;
using System.IO;

namespace PFEA.Controllers
{
    public class le_bien2Controller : Controller
    {
        private Agence_immobilierEntities11 db = new Agence_immobilierEntities11();

        // GET: le_bien2
        public async Task<ActionResult> Index()
        {
            return View(await db.le_bien.ToListAsync());
        }

        // GET: le_bien2/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            le_bien le_bien = await db.le_bien.FindAsync(id);
            if (le_bien == null)
            {
                return HttpNotFound();
            }
            return View(le_bien);
        }

        // GET: le_bien2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: le_bien2/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "id_bien,type_bien,superficie,description,localisation,prix,image,date_annonces")] le_bien le_bien)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.le_bien.Add(le_bien);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    } 
        public ActionResult Create([Bind(Include = "id_bien,type_bien,superficie,description,localisation,prix,image,File,date_annonces")] le_bien le_bien)
        {
            if (ModelState.IsValid)
            {
                string filename = Path.GetFileName(le_bien.File.FileName);
                string _filename = DateTime.Now.ToString("hhmmssfff") + filename;
                string path = Path.Combine(Server.MapPath("~/image/"), _filename);
                le_bien.image = "~/images/" + _filename;
                db.le_bien.Add(le_bien);
                if (le_bien.File.ContentLength < 1000000)
                {
                    if (db.SaveChanges() > 0)
                    {
                        le_bien.File.SaveAs(path);
                    }

                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg = "File must less than 1 MB";
                }
               
               
                
               
            }

            return View(le_bien);
        }

        // GET: le_bien2/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            le_bien le_bien = await db.le_bien.FindAsync(id);
            if (le_bien == null)
            {
                return HttpNotFound();
            }
            return View(le_bien);
        }

        // POST: le_bien2/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id_bien,type_bien,superficie,description,localisation,prix,image,date_annonces")] le_bien le_bien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(le_bien).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(le_bien);
        }

        // GET: le_bien2/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            le_bien le_bien = await db.le_bien.FindAsync(id);
            if (le_bien == null)
            {
                return HttpNotFound();
            }
            return View(le_bien);
        }

        // POST: le_bien2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            le_bien le_bien = await db.le_bien.FindAsync(id);
            db.le_bien.Remove(le_bien);
            await db.SaveChangesAsync();
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
        public ActionResult Gallery()
        {
            List<le_bien> all = new List<le_bien>();
            using (Agence_immobilierEntities11 agence = new Agence_immobilierEntities11())
            {
                all = agence.le_bien.ToList();
            }
            return View();
        }
    }
}
