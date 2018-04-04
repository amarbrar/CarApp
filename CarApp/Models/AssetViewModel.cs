using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public class AssetViewModel
    {
        [Required(ErrorMessage = "Barcode is required")]
        [RegularExpression(@"^\d{7}$",ErrorMessage = "Barcode should be 7 digit")]
        public int Barcode { get; set; }

        [Required(ErrorMessage ="Make a selection")]
        public int SelectionValue { get; set; }
    }
}