using CarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IssueAsset()
        {
            ViewBag.Message = "Add options to issue an asset";

            return View();
        }

        public ActionResult ReceiveAsset()
        {
            ViewBag.Message = "Add options to receive an asset";

            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Displays list of users";

            return View();
        }

        public ActionResult Assets()
        {
            ViewBag.Message = "Display list of assets";

            return View();
        }

        public ActionResult Centers()
        {
            ViewBag.Message = "Display list of Centers";

            return View();
        }

        public ActionResult Apos()
        {
            ViewBag.Message = "Display list of APOs";

            return View();
        }

        [HttpPost]
        public ActionResult IssueAsset(AssetViewModel model)
        {
            if(ModelState.IsValid)
            {

            }

            return View("IssueAsset");
        }
    }
}