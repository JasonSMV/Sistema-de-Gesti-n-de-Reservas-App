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
            
            return View();
        }

    }
}