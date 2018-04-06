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
            
            var assetList = new List<Asset>()
            {
                new Asset{Barcode = 1234567, DeviceName = "Device 1", Manufacturer = "Dell"},
                new Asset{Barcode = 2345678, DeviceName = "Device 2", Manufacturer = "Lenovo"},
                new Asset{Barcode = 3456789, DeviceName = "Device 3", Manufacturer = "Apple"},
                new Asset{Barcode = 4567890, DeviceName = "Device 4", Manufacturer = "IBM"}
            };
            return View(assetList);
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


        public void AddAsset()
        {
            var assetList = ViewBag.Assets;
        }

        [HttpPost]
        public ActionResult IssueAsset(AssetViewModel model)
        {
            if(ModelState.IsValid)
            {

            }

            return View("IssueAsset");
        }

        [HttpPost]
        public ActionResult ReceiveAsset(AssetViewModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View("ReceiveAsset");
        }
    }
}