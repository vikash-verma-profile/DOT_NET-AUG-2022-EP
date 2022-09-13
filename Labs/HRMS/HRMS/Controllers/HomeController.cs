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
        public IActionResult Register()
        {
            return View();
        }
    }
}
