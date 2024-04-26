//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using PFEA.Models;
//using System.Data.SqlClient;

//namespace PFEA.Controllers
//{
//    public class comptmController : Controller
//    {
//        SqlConnection cnx = new SqlConnection();
//        SqlCommand cmd = new SqlCommand();
//        SqlDataReader dr;
//        // GET: comptm
//        [HttpGet]
//        public ActionResult Login()
//        {
//            return View();
//        }
//        void connectionString()
//        {
//            cnx.ConnectionString = @"data source= DESKTOP-8DFI17Q\SQLEXPRESS; database=Agence_immobilier;integrated security=SSPI;";
//        }
//        [HttpPost]
//        public ActionResult Verify(compt co)
//        {
//            connectionString();
//            cnx.Open();
//            cmd.Connection = cnx;
//            cmd.CommandText = "select*from Personne where email='"+co.email+"' and mot_pass='"+co.password+"'";
//            dr = cmd.ExecuteReader();
//            if (dr.Read())
//            {
//                cnx.Close();

//                return View("Create");
//            }
//            else
//            {
//                cnx.Close();

//                return View("Error");
//            }
            
//        }
//    }
//}