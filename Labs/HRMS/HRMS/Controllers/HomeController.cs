using HRMS.Common;
using HRMS.Models;
using HRMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Controllers
{
    public class HomeController : Controller
    {
        HRMSDBContext db = new HRMSDBContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(Login login)
        {

            if (ModelState.IsValid)
            {
                //
            }
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                TblUser user = new TblUser();
                user.FirstName = register.FirstName;
                user.LastName = register.LastName;
                user.EmailId = register.EmailId;
                user.Password = register.Password;
                user.Dob = register.Dob;

                switch (register.Gender)
                {
                    case "Male":
                        {
                            user.Gender = (int)EGender.Male;
                            break;
                        }
                    case "Female":
                        {
                            user.Gender = (int)EGender.Female;
                            break;
                        }
                    case "Other":
                        {
                            user.Gender = (int)EGender.Other;
                            break;
                        }

                }
                db.TblUsers.Add(user);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
