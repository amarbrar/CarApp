using CarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Controllers
{
    public static class CenterRepository
    {
        public static IEnumerable<Center> GetCenters()
        {
            var centers = new List<Center>
            {
                new Center{ Id = 1, Name="OIMT", Description = ""},
                new Center{ Id = 2, Name="CDER", Description = ""},
                new Center{ Id = 3, Name="CBER", Description = ""},
                new Center{ Id = 4, Name="CTP", Description = ""}
            };

            return centers;
        }

        public static void MapCenter(Center original, Center changed)
        {
            original.Name = changed.Name;
            original.Description = changed.Description;
            original.LastUpdated = DateTime.Now;
        }
    }
}