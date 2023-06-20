using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceAdmin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactUs() { return View(); }
        public ActionResult FormsLayouts() { return View(); }
        public ActionResult UsersProfile() { return View(); }
        public ActionResult FormEdit() { return View(); }
        public ActionResult DataTable() { return View(); }
    }
}