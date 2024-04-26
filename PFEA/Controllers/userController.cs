using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PFEA.Models;

namespace PFEA.Controllers
{
    public class userController : Controller
    {
        Agence_immobilierEntities5 agence = new Agence_immobilierEntities5();
        // GET: user
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Inscription()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inscription(Personne p)
        {
            agence.Personne.Add(p);
            agence.SaveChanges();
            return View();
        }

        //public ActionResult connexion()
        //{
        //    return View();
        //}
        //public ActionResult connexion(Personne P)
        //{
        //    var cnx = agence.Personne.Where(a => a.email.Equals(P.email) && a.mot_pass.Equals(P.mot_pass)).FirstOrDefault();
        //    if (agence != null)
        //    {
        //        return RedirectToAction("index", "user");
        //    }
        //    else
        //    {
        //        return RedirectToAction("connexion", "user");
        //    }

        //}

    }
}