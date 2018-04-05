using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public class User
    {
        [Key]
        public long BadgeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Email { get; set; }
        //public DateTime? Accepted { get; set; }
        //[ForeignKey("BARCODE")]
        //public string BARCODE { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsApoPco { get; set; }
        public bool CanSendReminder { get; set; }
        //public string PREVIOUS_BARCODE { get; set; }
        //public bool? HasOutstandingAsset { get; set; }
        //public DateTime? LastReminder { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public bool IsActive { get; set; }

        //public virtual APO_PCO APO_PCO { get; set; }
        //public virtual ASSET ASSET { get; set; }
    }
}