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
            if (Session["users"] == null)
                Session["users"] = UserRepository.GetUsers();

            return View(Session["users"]);
        }

        public ActionResult UpdateUser(User value)
        {
            IList<User> users = new List<User>();
            if (Session["users"] != null)
                users = (IList<User>)Session["users"];

            var user = users.FirstOrDefault(u => u.BadgeNumber == value.BadgeNumber);
            UserRepository.MapUser(user, value);

            Session["users"] = users;

            return View(Session["users"]);
        }

        public ActionResult Assets()
        {
            if (Session["assets"] == null)
                Session["assets"] = AssetRepository.GetAssets();

            return PartialView("AssetsListView", Session["assets"]);
        }

        public ActionResult UpdateAsset(Asset value)
        {
            IList<Asset> assets = new List<Asset>();
            if(Session["assets"] != null)
                assets = (IList<Asset>) Session["assets"];

            var asset = assets.FirstOrDefault(a => a.Barcode == value.Barcode);
            if (asset != null)
                AssetRepository.MapAsset(asset, value);
            else
            {
                value.Created = DateTime.Now;
                assets.Add(value);
            }

            Session["assets"] = assets;

            return PartialView("AssetsListView", Session["assets"]);
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