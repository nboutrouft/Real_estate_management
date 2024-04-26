using System.Web.Mvc;
using PFEA.Models;
namespace PFEA.Controllers
{
    public class printController : Controller
    {
        // GET: print
        Agence_immobilierEntities11 context;
        public printController()
        {
            context = new Agence_immobilierEntities11();
        }
        public ActionResult Getall()
        {
            var allPrint = context.le_bien;
            return View(allPrint);
        }

    }
  
}