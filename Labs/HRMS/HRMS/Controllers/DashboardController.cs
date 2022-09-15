using HRMS.Common;
using HRMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Controllers
{
    [SessionFilter]
    public class DashboardController : Controller
    {
        HRMSDBContext db = new HRMSDBContext();
  
        public IActionResult Index()
        {
           var userdata=db.TblUsers.Where(x=>x.Id== HttpContext.Session.GetInt32("UserId")).FirstOrDefault() ;
            ViewBag.UserName = userdata.FirstName +" "+ userdata.LastName;
            return View();
        }

        public IActionResult GetMenu()
        {
            int UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
            var menu = db.TblMenus.Join(db.TblRoleMenuMappings, m => m.Id, rmm => rmm.MenuId, (m, rmm) => new { m, rmm }).Join(db.TblRoles, rm => rm.rmm.RoleId, r => r.Id, (rmm, r) => new { rmm, r }).Join(db.TblUsers, ur => ur.r.Id, u => u.RoleId, (ur, u) => new { ur, u }).Where(x => x.u.Id == UserId).Select(x=>new {Id= x.ur.rmm.m.Id , MenuText = x.ur.rmm.m.MenuText,Link= x.ur.rmm.m.Link,ParentID= x.ur.rmm.m.ParentId });
            return Json(menu);
        }
    }
}
