using HRMSAPI.Models;
using HRMSAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        HRMSDBContext db = new HRMSDBContext();

        [HttpGet]
        public IEnumerable<MenuViewModel> Get(int id)
        {
            List<MenuViewModel> menu = db.TblMenus.Join(db.TblRoleMenuMappings, m => m.Id, rmm => rmm.MenuId, (m, rmm) => new { m, rmm }).Join(db.TblRoles, rm => rm.rmm.RoleId, r => r.Id, (rmm, r) => new { rmm, r }).Join(db.TblUsers, ur => ur.r.Id, u => u.RoleId, (ur, u) => new { ur, u }).Where(x => x.u.Id == id).Select(x => new MenuViewModel  { Id = x.ur.rmm.m.Id, MenuText = x.ur.rmm.m.MenuText, Link = x.ur.rmm.m.Link, ParentID = Convert.ToInt32(x.ur.rmm.m.ParentId) }).ToList();
            return menu;
        }
    }
}
