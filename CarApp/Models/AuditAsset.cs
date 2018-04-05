using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public class AuditAsset
    {
        public int Barcode { get; set; }
        public int AssignedTo { get; set; }
        public int AssignedBy { get; set; }
        public int StateId { get; private set; }
        public DateTime CreatedTimestamp { get; set; }
    }
}