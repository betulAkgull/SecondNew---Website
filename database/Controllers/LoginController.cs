using database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace database.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(database.Models.registeredUser user)
        {
            using (dbModel db = new dbModel())
            {
                var userDetails = db.registeredUser.Where(x => x.username == user.username && x.password == user.password).FirstOrDefault();
                if(userDetails == null)
                {
                    user.loginErrorMessage = "Wrong username or password.";
                    return View("Index", user);
                }
                else
                {
                    Session["userid"] = userDetails.userid;
                    return RedirectToAction("myhomepage", "Product");
                }
            }
                
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Product");
        }
    }
}