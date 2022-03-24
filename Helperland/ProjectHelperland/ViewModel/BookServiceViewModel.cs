using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHelperland.ViewModel
{
    public class BookServiceViewModel
    {
        public List<AddressViewModel> address { get; set; }
        public ZipCodeViewModel zipCodeViewModel { get; set; }
        public ServiceRequestViewModel ServiceRequestViewModel { get; set; }
        public int addressId { get; set; }
        [Required]

        public int addressId2 { get; set; }

        public string postalCode { get; set; }

        public class MustBeTrueAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return value is bool && (bool)value;
            }
        }
        [MustBeTrue(ErrorMessage = "Please accept privacy policy")]
        [Required]
        public bool checkPolicy { get; set; }

        public string streetname { get; set; }

        public string cityname { get; set; }

        public int houseno { get; set; }

        public string phonenumber { get; set; }


    }
}
