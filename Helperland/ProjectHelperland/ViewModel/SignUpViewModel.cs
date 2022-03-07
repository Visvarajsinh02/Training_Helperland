using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHelperland.ViewModel
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }

        public class MustBeTrueAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return value is bool && (bool)value;
            }
        } 
        [MustBeTrue(ErrorMessage = "Please accept Privacy Policy")]
        public bool PrivacyPolicy { get; set; }
    }
}
