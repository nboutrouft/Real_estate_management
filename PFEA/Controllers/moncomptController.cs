using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFEA.Controllers
{
    public class moncomptController : Controller
    {
        // GET: moncompt
        public ActionResult Publier_annonce()
        {
            return View();
        }
        public ActionResult Acceuil()
        {
            return View();
        }
        public ActionResult mes_Annonces()
        {
            return View();
        }
        public ActionResult Favoris()
        {
            return View();
        }
        public ActionResult Déconnecté()
        {
            return View();
        }
    }
}