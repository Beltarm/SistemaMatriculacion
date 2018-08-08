using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMatriculacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult dashboardAdmin()
        {
            return View();
        }

        public ActionResult logueado()
        {
            if (User.IsInRole("admin"))
            {
                return RedirectToAction("dashboardAdmin", "Home");
            }
            else if (User.IsInRole("user"))
            {
                return RedirectToAction("dashboard", "estudiante");
            }

            return View("Index");
        }
    }
}