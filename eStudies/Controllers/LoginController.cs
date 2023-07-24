using eStudies.Data;
using eStudies.Models;
using Microsoft.AspNetCore.Mvc;

namespace eStudies.Controllers
{
    public class LoginController : Controller
    {
        eStudiesDbContext db;
        public LoginController(eStudiesDbContext dbc)
        {
            db = dbc;
        }

        //Get
        [HttpGet]
        public IActionResult ULogin()
        {
            return View();
          }

        //Post

        [HttpPost]
        public IActionResult ULogin(Register r)
        {
            var x = db.Registers.Where(a => a.UserEmail.Equals(r.UserEmail) && a.Password.Equals(r.Password)).SingleOrDefault();

            if (x != null)
            {
                if (x.UserTypeId == 1)
                {
                    //RedirectToAction("Index", "Home");  
                    ViewBag.u = x.UserName;
                    ViewBag.m = "welcome Student";
                }

                if (x.UserTypeId == 2)
                {
                    //RedirectToAction("Index", "Home");  
                    ViewBag.u = x.UserName;
                    ViewBag.m = "welcome Teacher";
                }

                if (x.UserTypeId == 3)
                {
                    //RedirectToAction("Index", "Home");  
                    ViewBag.u = x.UserName;
                    ViewBag.m = "welcome Parent/Guardian";
                }
            }
            else
            {
                ViewBag.m = "ERROR";
            }
            return View();
        }
    }
}
