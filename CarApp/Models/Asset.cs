using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public class Asset
    {
        public int Barcode { get; set; }
        public string DeviceName { get; set; }
        public string Manufacturer { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}