using DataAccessLibrary;
using Sistema_de_Gestión_de_Reservas.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_de_Gestión_de_Reservas.Controllers
{
    public class HomeController : Controller
    {
        SqlCrud sql = new SqlCrud(Utilities.GetConnectionString());
        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            var row = sql.GetSalas();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}