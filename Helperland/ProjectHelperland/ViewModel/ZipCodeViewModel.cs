using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHelperland.ViewModel
{
    public class ZipCodeViewModel
    {
       /* [Required(ErrorMessage = "Please enter your postal code!")]*/
        public string zipcode { get; set; }
    }
}
