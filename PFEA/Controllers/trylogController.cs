using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PFEA.Models;

namespace PFEA.Controllers
{
    public class trylogController : Controller
    {
        Agence_immobilierEntities5 immo = new Agence_immobilierEntities5();
        
        // GET: trylog
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Personne go)
        {
            var goes = immo.Personne.Where(y => y.email == go.email && y.mot_pass == y.mot_pass).Count();
            if(goes>0)
            {
                return RedirectToAction("Myaccount");
            }else
            {
                return View();

            }
        }
        public ActionResult Myaccount()
        {
            return View();
        }
    }
}