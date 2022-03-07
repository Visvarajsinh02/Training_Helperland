using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHelperland.ViewModel
{
    public class ContactUsViewModel
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }
        
        
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email format")]
        [Required]
        public string Email { get; set; }
        public string Subject { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a Message")]
        public string Message { get; set; }
    }
}
