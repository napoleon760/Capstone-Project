using Eticketer.web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Eticketer.web.Controllers
{
    public class AccountController : Controller
    {

        public IAuthenticationManager Authentication => this.HttpContext.GetOwinContext().Authentication;//
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model, string ReturnUrl)
        {
            //TODO:Peform validation
            var IsValid = true;

            //Sign User in
            if (IsValid)
            {
                SignIn(model);

                //Redirect to Home
                if (!string.IsNullOrEmpty(ReturnUrl))
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("dashboard", "account");

                }

            }
            else
            {
                return View(model);
            }
        }

        private void SignIn(LoginModel model)
        {
            var claims = new Claim[] //create claims
                        {
                new Claim(ClaimTypes.NameIdentifier, "1"),
                new Claim(ClaimTypes.Email,model.Email),
                new Claim(ClaimTypes.Name, model.Email)

                        };

            var identity = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

            Authentication.SignIn(identity);
        }

        public ActionResult Logout()
        {
            Authentication.SignOut();
            return RedirectToAction("login");
        }


        public ActionResult Dashboard()
        {
            return View();
        }
    }
}