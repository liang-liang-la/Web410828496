using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410828496.ViewModels;

namespace Web410828496.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Signup()
        {
            return View(new SignUpData());
        }

        [HttpPost]
        public ActionResult Signup(SignUpData data)
        {
            
            if (ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}