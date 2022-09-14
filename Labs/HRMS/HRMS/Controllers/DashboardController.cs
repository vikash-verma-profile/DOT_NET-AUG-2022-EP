using HRMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Controllers
{
    public class DashboardController : Controller
    {
        HRMSDBContext db = new HRMSDBContext();
        public IActionResult Index()
        {
           var userdata=db.TblUsers.Where(x=>x.Id== HttpContext.Session.GetInt32("UserId")).FirstOrDefault() ;
            ViewBag.UserName = userdata.FirstName +" "+ userdata.LastName;
            return View();
        }
    }
}
