using HRMS.Common;
using HRMS.Models;
using HRMS.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public async Task<IActionResult> Login(Login login)
        {

            if (ModelState.IsValid)
            {
                //if(db.TblUsers.Any(x=>x.EmailId==login.UserName && x.Password == login.Password))
                // {
                //     var userData = db.TblUsers.Where(x => x.EmailId == login.UserName && x.Password == login.Password).FirstOrDefault();
                //     HttpContext.Session.SetInt32("UserId", userData.Id);
                //     return RedirectToAction("Index", "Dashboard");
                // }
                // else
                // {

                // }
                var loginResponesObject = new LoginResponse();
                var client = new HttpClient();
                client.BaseAddress = new Uri(Constants.BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var loginjson = JsonConvert.SerializeObject(login);
                HttpResponseMessage res = await client.PostAsync(Constants.loginendpoint,new StringContent(loginjson,Encoding.UTF8, "application/json"));
                if (res.IsSuccessStatusCode)
                {
                    var loginresult = res.Content.ReadAsStringAsync().Result;
                    loginResponesObject = JsonConvert.DeserializeObject<LoginResponse>(loginresult);
                    if (loginResponesObject.Status == 200)
                    {
                        HttpContext.Session.SetInt32("UserId", loginResponesObject.UserId);
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
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
                HttpContext.Session.SetInt32("UserId", user.Id);
            }

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
