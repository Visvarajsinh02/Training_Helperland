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
        private readonly ILogger<HomeController> _logger;
        private readonly HelperlandContext _helperlandContext;

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
                return View("~/Views/Home/SpSignUp.cshtml");
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
                var details = (from userlist in _helperlandContext.Users
                               where userlist.Email == loginViewModel.Email && userlist.Password == loginViewModel.Password
                               select new
                               {
                                   userlist.UserId,
                                   userlist.FirstName,
                                   userlist.UserTypeId
                               }).ToList();
                if (details.FirstOrDefault() != null)
                {
                    HttpContext.Session.SetString("UserId",
                                                  details.FirstOrDefault().UserId.ToString());
                    HttpContext.Session.SetString("FirstName", details.FirstOrDefault().FirstName);
                    HttpContext.Session.SetString("UserTypeId", details.FirstOrDefault().UserTypeId.ToString());

                    return RedirectToAction("welcome", "Home");
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
                var details = (from userlist in _helperlandContext.Users
                               where userlist.Email == loginViewModel.Email
                               select new
                               {
                                   userlist.UserId,
                                   userlist.FirstName,
                                   userlist.Email,
                                   userlist.Password
                               }).ToList();
                if (details.FirstOrDefault() != null)
                {
                    HttpContext.Session.SetString("UserId",
                                                  details.FirstOrDefault().UserId.ToString());
                    HttpContext.Session.SetString("FirstName", details.FirstOrDefault().FirstName);
                    HttpContext.Session.SetString("Email", details.FirstOrDefault().Email);


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
            int id = Int32.Parse(HttpContext.Session.GetString("UserId"));
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
        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult Price()
        {
            return View();
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
