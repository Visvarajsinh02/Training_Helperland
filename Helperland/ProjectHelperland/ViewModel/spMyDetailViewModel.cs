using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHelperland.ViewModel
{
    public class spMyDetailViewModel
    {
        [Required(ErrorMessage = "Please enter your firstname")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Please enter your lastname")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phonenumber")]
        public string phone { get; set; }


        [Required(ErrorMessage = "Please enter your street name")]
        public string street { get; set; }
        [Required(ErrorMessage = "Please enter your house number")]
        public int house { get; set; }
        [Required(ErrorMessage = "Please enter your postalcode")]
        public string postal { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        public string city { get; set; }
    }
}
