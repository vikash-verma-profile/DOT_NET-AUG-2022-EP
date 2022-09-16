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
    public class LoginController : ControllerBase
    {
        HRMSDBContext db = new HRMSDBContext();
        [HttpPost]
        public IActionResult Post(Login login)
        {
            if (db.TblUsers.Any(x => x.EmailId == login.UserName && x.Password == login.Password))
            {
                var userData = db.TblUsers.Where(x => x.EmailId == login.UserName && x.Password == login.Password).FirstOrDefault();
                return Ok(new { Status=200,Message="success",UserId=userData.Id});
            }
            else
            {
                return BadRequest(new { Status = 200, Message = "Either UserName or password is not valid." });
            }
        }
    }
}
