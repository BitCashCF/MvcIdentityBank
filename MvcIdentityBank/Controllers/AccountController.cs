using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcIdentityBank.Controllers
{
    public class AccountController : Controller
    {
        //for Users managment
        public CustomUserManager UserManager
        {
            get => HttpContext.GetOwinContext().GetUserManager<CustomUserManager>();
        }

        //for register,login,logout ...& other identity operations
        private IAuthenticationManager AuthManager
        {
            get => HttpContext.GetOwinContext().Authentication;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View()
        }


    }
}