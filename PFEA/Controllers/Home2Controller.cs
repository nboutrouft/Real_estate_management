using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace PFEA.Controllers
{
    public class Home2Controller : Controller
    {
        
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult sitenunu()
        {
            return View();
        }

        public ActionResult Annonce()
        {
            return View();
        }

        public ActionResult Connexion()
        {
            return View();
        }
        public ActionResult inscriez()
        {
            return View();
        }
        public ActionResult Apropos()
        {
            return View();
        }
        public ActionResult Myaccount()
        {
            return View();
        }
        public ActionResult Pub_annoce()
        {
            return View();
        }
    }
}