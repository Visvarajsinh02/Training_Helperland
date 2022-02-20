using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectHelperland.Data;
using ProjectHelperland.Models;
using ProjectHelperland.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjectHelperland.Controllers
{
    public class HomeController : Controller
    {
        public static int cnt = 0;
        private readonly ILogger<HomeController> _logger;
        private readonly HelperlandContext _helperlandContext;

        BookServiceViewModel userAddresses = new BookServiceViewModel();

        public HomeController(ILogger<HomeController> logger, HelperlandContext helperlandContext)
        {
            _logger = logger;
            _helperlandContext = helperlandContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            SignUpViewModel signUpViewModel = new SignUpViewModel();
            return View(signUpViewModel);
        }

        [HttpPost]

        public IActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            var email_check = email_exist(signUpViewModel.Email);
            if (email_check)
            {
                ModelState.AddModelError("Email", "Email already exist");
                return View();
            }
            else
            {
                User user = new User()
                {
                    FirstName = signUpViewModel.FirstName,
                    LastName = signUpViewModel.LastName,
                    Email = signUpViewModel.Email,
                    Mobile = signUpViewModel.PhoneNumber,
                    Password = signUpViewModel.Password,

                    UserTypeId = 1,
                    IsRegisteredUser = true,
                    WorksWithPets = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = 0,
                    IsApproved = true,
                    IsActive = true,
                    IsDeleted = false
                };
                _helperlandContext.Users.Add(user);
                _helperlandContext.SaveChanges();
                ViewBag.successModal = string.Format("valid");
                return View("~/Views/Home/Index.cshtml");
            }
            
        }

        public IActionResult SpSignUp()
        {
            //SignUpViewModel signUpViewModel = new SignUpViewModel();
            return View();
        }

        [HttpPost]

        public IActionResult SpSignUp(SignUpViewModel signUpViewModel)
        {
            var email_check = email_exist(signUpViewModel.Email);
            if (email_check)
            {
                ModelState.AddModelError("Email", "Email already exist");
                return View();
            }
            else
            {
                User user = new User()
                {
                    FirstName = signUpViewModel.FirstName,
                    LastName = signUpViewModel.LastName,
                    Email = signUpViewModel.Email,
                    Mobile = signUpViewModel.PhoneNumber,
                    Password = signUpViewModel.Password,

                    UserTypeId = 2,
                    IsRegisteredUser = true,
                    WorksWithPets = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = 0,
                    IsApproved = true,
                    IsActive = true,
                    IsDeleted = false
                };
                _helperlandContext.Users.Add(user);
                _helperlandContext.SaveChanges();
                ViewBag.successModal = string.Format("valid");
                return View("~/Views/Home/Index.cshtml");
            }
            
            

        }
        public IActionResult Index_Login()
        {
            ViewBag.modal = string.Format("invalid");
            return View("~/Views/Home/Index.cshtml");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = _helperlandContext.Users.Where(x => x.Email == loginViewModel.Email.Trim() && x.Password == loginViewModel.Password.Trim()).FirstOrDefault();

                /*var details = (from userlist in _helperlandContext.Users
                               where userlist.Email == loginViewModel.Email && userlist.Password == loginViewModel.Password
                               select new
                               {
                                   userlist.UserId,
                                   userlist.FirstName,
                                   userlist.UserTypeId
                               }).ToList();*/
                if (user != null)
                {
                    HttpContext.Session.SetString("UserId",
                                                  user.UserId.ToString());
                    HttpContext.Session.SetString("FirstName", user.FirstName);
                    HttpContext.Session.SetString("UserTypeId", user.UserTypeId.ToString());

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials");
                    ViewBag.modal = string.Format("invalid");
                    return View("~/Views/Home/Index.cshtml");
                }
            }
            return View(loginViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPass(LoginViewModel loginViewModel)
        {
           
            var email_check = email_exist(loginViewModel.Email);
            //Debug.WriteLine("this is bool of email_check :" + email_check);
            if (email_check)
            {
                User user = _helperlandContext.Users.Where(x => x.Email == loginViewModel.Email.Trim()).FirstOrDefault();

                /*var details = (from userlist in _helperlandContext.Users
                               where userlist.Email == loginViewModel.Email
                               select new
                               {
                                   userlist.UserId,
                                   userlist.FirstName,
                                   userlist.Email,
                                   userlist.Password
                               }).ToList();*/
                if (user != null)
                {
                    HttpContext.Session.SetString("Userid",
                                                  user.UserId.ToString());
                    HttpContext.Session.SetString("Firstname", user.FirstName);
                    HttpContext.Session.SetString("email", user.Email);


                }
            }
            else
            {
                ModelState.AddModelError("Email", "User does not Exist!");
                ViewBag.frgtpass = string.Format("forgot pass");
                return View("~/Views/Home/Index.cshtml");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(LoginViewModel loginViewModel)
        {
            int id = Int32.Parse(HttpContext.Session.GetString("Userid"));
            User user = _helperlandContext.Users.Where(x => x.UserId == id).FirstOrDefault();
            user.Password = loginViewModel.Password;
            _helperlandContext.Update(user);
            _helperlandContext.SaveChanges();
            ViewBag.changepass = string.Format("chengepass");
            return View("~/Views/Home/Index.cshtml");
        }
        public IActionResult welcome()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
       
        public IActionResult About() 
        {
            return View();
        }

        public IActionResult Contact()
        {
            ContactUsViewModel contactUsViewModel = new ContactUsViewModel();
            return View(contactUsViewModel);
        }

        [HttpPost]
        public IActionResult Contact(ContactUsViewModel contactUsViewModel)
        {
            if (ModelState.IsValid)
            {
                ContactU contactU = new ContactU()
                {
                    Name = contactUsViewModel.FirstName + " " + contactUsViewModel.LastName,
                    Email = contactUsViewModel.Email,
                    PhoneNumber = contactUsViewModel.PhoneNumber,
                    Subject = contactUsViewModel.Subject,
                    Message = contactUsViewModel.Message,
                    CreatedOn = DateTime.Now
                };

                _helperlandContext.ContactUs.Add(contactU);
                _helperlandContext.SaveChanges();
                return RedirectToAction("Contact");
            }

            return View();
           
        }
        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult Price()
        {
            return View();
        }

        public IActionResult BookService()
        {
            if(HttpContext.Session.GetString("FirstName") == null){
                return RedirectToAction("Index_Login","Home");
            }
            else
            {
                string uname = HttpContext.Session.GetString("FirstName");
                ViewBag.Uname = uname;
                ViewBag.login_check = String.Format("loggedin");
                if (cnt != 0)
                {
                    if (HttpContext.Session.GetString("again_called") != "spfound")
                    {
                        HttpContext.Session.SetString("ss_step_2", "notset");
                        ViewBag.foundsp = string.Format("spnotfound");
                        string temp_var = ViewBag.foundsp;
                        Debug.WriteLine("this is viewbag foundsp" + temp_var);
                    }
                    else
                    {
                        ViewBag.foundsp = null;
                        HttpContext.Session.SetString("ss_step_2", "notset");

                    }

                }
                cnt = 1;
                getAddress();

                return View(userAddresses);
            }
               
        }

        public void getAddress()
        {
            Debug.WriteLine("this methd is called");

            HttpContext.Session.SetString("getaddress", "set");
            var userid = Int32.Parse(HttpContext.Session.GetString("UserId"));

            var addresses = (from uaddress in _helperlandContext.UserAddresses
                             where uaddress.UserId == userid
                             select new AddressViewModel()
                             {

                                 addressline1 = uaddress.AddressLine1,

                                 city = uaddress.City,
                                 phonenumber = uaddress.Mobile,

                                 postalcode = uaddress.PostalCode
                             }).ToList();

            if (addresses.FirstOrDefault() != null)
            {
                userAddresses.address = new List<AddressViewModel>();
                int countAddress = 1;

                foreach (var add in addresses)
                {

                    add.id = countAddress;
                    userAddresses.address.Add(add);

                    countAddress += 1;
                }

            }

        }

        public bool email_exist(string email)
        {
            var isCheck = _helperlandContext.Users.Where(eMail => eMail.Email == email).FirstOrDefault();
            return isCheck != null;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
