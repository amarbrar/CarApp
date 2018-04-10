using CarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Controllers
{
    public static class AssetRepository
    {
        //public IEnumerable<Asset> Assets { get; private set; }

        //private static void DefaultAssetList()
        //{
        //    Assets = new List<Asset>()
        //    {
        //        new Asset{Barcode = 1234567, DeviceName = "Device 1", Manufacturer = "Dell"},
        //        new Asset{Barcode = 2345678, DeviceName = "Device 2", Manufacturer = "Lenovo"},
        //        new Asset{Barcode = 3456789, DeviceName = "Device 3", Manufacturer = "Apple"},
        //        new Asset{Barcode = 4567890, DeviceName = "Device 4", Manufacturer = "IBM"}
        //    };
        //}

        public static IEnumerable<Asset> GetAssets()
        {
            var assets = new List<Asset>()
                {
                    new Asset{Barcode = 1234567, DeviceName = "Device 1", Manufacturer = "Dell"},
                    new Asset{Barcode = 2345678, DeviceName = "Device 2", Manufacturer = "Lenovo"},
                    new Asset{Barcode = 3456789, DeviceName = "Device 3", Manufacturer = "Apple"},
                    new Asset{Barcode = 4567890, DeviceName = "Device 4", Manufacturer = "IBM"}
                };

            return assets;
        }

        public static void MapAsset(Asset original, Asset changed)
        {
            original.Barcode = changed.Barcode;
            original.DeviceName = changed.DeviceName;
            original.Manufacturer = changed.Manufacturer;
            original.LastUpdated = DateTime.Now;
        }

        //public static void Add(Asset item)
        //{
        //    DefaultAssetList();
        //    Assets.ToList().Add(item);
        //}
    }
}