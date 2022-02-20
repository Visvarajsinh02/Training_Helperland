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
        
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" , ErrorMessage = "Invalid Email Format")]

        public string Email { get; set; }
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number")]
        [MaxLength(10, ErrorMessage = "Please enter a valid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a Message")]
        public string Message { get; set; }
    }
}
