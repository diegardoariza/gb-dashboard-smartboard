using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GBDashboard.Controllers
{
    public class HomeController : Controller
    {
        //GET /home/index
        public ActionResult Index()
        {
            return View();
        }

        //GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "GB Dashboard - SmartBoard is a software application that support our customers to make their life easier.";

            return View();
        }

        //GET /home/contact
        public ActionResult Contact()
        {
            ViewBag.Message = "If you want to contat us please write to us.";

            return View();
        }

        //GET /home/contact
        public ActionResult ViewFacesheet(String facesheetId)
        {
            Int32 id = Int32.Parse(facesheetId);
            //return FacesheetsController.Details(id);
            return RedirectToAction("Details", "Facesheets");
        }
    }
}