using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHelperland.ViewModel
{
    public class MyDetailViewModel
    {
        [Required(ErrorMessage = "Please enter your street name")]
        public string street { get; set; }

        [Required(ErrorMessage = "Please enter your house number")]
        public int hno { get; set; }

        [Required(ErrorMessage = "Please enter your phone number"), MaxLength(10)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please enter your street pincode")]
        public string pincode { get; set; }

        [Required(ErrorMessage = "Please enter your city name")]
        public string city { get; set; }
    }
}
