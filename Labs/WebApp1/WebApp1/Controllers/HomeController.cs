using Microsoft.AspNetCore.Http;
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
            HttpContext.Session.SetInt32("IsEdit",0);
            return View();
        }

        public IActionResult Submit(TblUserDetail tblUserDetail)
        {
            if (HttpContext.Session.GetInt32("IsEdit") == 1)
            {
                db.TblUserDetails.Update(tblUserDetail);
                db.SaveChanges();
            }
            else
            {
                db.TblUserDetails.Add(tblUserDetail);
                db.SaveChanges();
            }
          
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            var list = db.TblUserDetails;
            return View(list);
        }
        public IActionResult Edit(int UserId)
        {
            HttpContext.Session.SetInt32("IsEdit", 1);
            var data=db.TblUserDetails.Where(x=>x.Id==UserId).FirstOrDefault();
            return View("Index", data);
        }
        public IActionResult Delete(int UserId)
        {
            var data = db.TblUserDetails.Where(x => x.Id == UserId).FirstOrDefault();
            db.TblUserDetails.Remove(data);
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
