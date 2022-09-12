using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        WebDBContext db = new WebDBContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submit(TblUserDetail tblUserDetail)
        {
            db.TblUserDetails.Add(tblUserDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult List()
        {
            var list = db.TblUserDetails;
            return View(list);
        }
        public IActionResult Edit(int UserId)
        {
            var data=db.TblUserDetails.Where(x=>x.Id==UserId).FirstOrDefault();
            return View("Index", data);
        }

       
    }
}
