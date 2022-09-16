using HRMSAPI.Models;
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
    public class HomeController : ControllerBase
    {
        HRMSDBContext db = new HRMSDBContext();

        [HttpGet]
        public IEnumerable<TblUser> Get()
        {
            return db.TblUsers;
        }
        [HttpPost]
        public IActionResult Post(TblUser user)
        {
            db.TblUsers.Add(user);
            db.SaveChanges();
            return Ok(new { Status="record added succesfully"});
        }

        [HttpPut]
        public IActionResult Put(TblUser user)
        {
            db.TblUsers.Update(user);
            db.SaveChanges();
            return Ok(new { Status = "record updated succesfully" });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var user = db.TblUsers.Where(x => x.Id == id).FirstOrDefault();
            db.TblUsers.Remove(user);
            db.SaveChanges();
            return Ok(new { Status = "record deleted succesfully" });
        }
    }
}
