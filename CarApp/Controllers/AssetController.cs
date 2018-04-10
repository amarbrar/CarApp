using CarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;


namespace CarApp.Controllers
{
    public class AssetController : ApiController
    {
        private static IEnumerable<Asset> _assets = new List<Asset>()
            {
                new Asset{Barcode = 1234567, DeviceName = "Device 1", Manufacturer = "Dell"},
                new Asset{Barcode = 2345678, DeviceName = "Device 2", Manufacturer = "Lenovo"},
                new Asset{Barcode = 3456789, DeviceName = "Device 3", Manufacturer = "Apple"},
                new Asset{Barcode = 4567890, DeviceName = "Device 4", Manufacturer = "IBM"}
            };

        //public ActionResult Get()
        //{
        //    return PartialViewResult("Asw")
        //}

        // GET api/<controller>
        public JsonResult<IEnumerable<Asset>> Get()
        {
            return Json(_assets);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public JsonResult<IEnumerable<Asset>> Update([FromBody]Asset value)
        {
            //var assets = AssetRepository.GetAssets();
            var assets = _assets.ToList();
                assets.Add(value);

            return Json((IEnumerable<Asset>)assets);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}