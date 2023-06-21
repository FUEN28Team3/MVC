using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sierra._0620.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
           
            return View();
        }
        public ActionResult FormsLayouts() { return View(); }
        public ActionResult UsersProfile() { return View(); }
        public ActionResult FormEdit() { return View(); }
        public ActionResult DataTable() { return View(); }
    }
}