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
        public IEnumerable<TblUser> Get()
        {
            return db.TblUsers;
        }
    }
}
