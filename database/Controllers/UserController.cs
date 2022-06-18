using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using database.Models;

namespace database.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            registeredUser userModel = new registeredUser();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(registeredUser user)
        {
            using (DbModel dbModel = new dbModel())
            {
                dbModel.registeredUser.Add(user);
                dbModel.SaveChanges();
            }


            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull";
            return RedirectToAction("Index", "Login");
        }
    }
}