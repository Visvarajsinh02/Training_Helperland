using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectHelperland.ViewModel
{
    public class spMySettingViewModel
    {
        public List<NewServiceRequestViewModel> newServices { get; set; }
        public List<UpcomingServiceViewModel> upcomingServices { set; get; }
        public List<spServiceHistoryViewModel> spServiceHistories { get; set; }
        public List<spMyratingViewModel> spMyratings { get; set; }
        public List<spBlockCustomersViewModel> spBlockCustomers { get; set; }
        public int hidden_nsr_ser_id { get; set; }
        public int hidden_complete_ser_id { get; set; }
        public int hidden_cancel_ser_id { get; set; }
        public int customer_id { get; set; }
        //--------------------for sp detail screen----------------------
        public bool is_active { get; set; }

       
       
        public int? nationalityid { get; set; }
        public int dob_day { get; set; }
        public int dob_month { get; set; }
        public int dob_year { get; set; }

        public int? gender { get; set; }
        public string avatar { get; set; }

       
       
        public int hidden_avatar { get; set; }


       //[Required(ErrorMessage = "Old Password is required")]
        public string pwd { get; set; }

        public ChangePasswordViewModel change { get; set; }

        public spMyDetailViewModel spmydetail { get; set; }

    }
}
