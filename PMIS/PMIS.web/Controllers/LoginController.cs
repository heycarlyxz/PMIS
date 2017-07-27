using PMIS.DAL;
using PMIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PMIS.web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();

        }

        [HttpPost]
        public ActionResult Index(Users user)
        {
            Users model = new Users();
            model.Username = user.Username;
            model.Password = user.Password;

            model = UsersData.checkIfExists(model);

            if (ModelState.IsValid)
            {
                

                if (model != null)
                {
                   return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username or Password");
                }
                
            }
            else
            {
                ModelState.AddModelError("", "Invalid Username or Password");
            }

            return View(model);
        }



    }
}