using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVCMySql.Models;
namespace DemoMVCMySql.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(ProfileModel model, string actionRequest)
        {

            if (model.UserID != null && model.UserID.Length > 0 && model.Password != null && model.Password.Length > 0)
            {
                model = new KIPPDemoDAO().LoginValidation(model.UserID, model.Password);

                if (model == null)
                {
                     ModelState.AddModelError(string.Empty, "UserId or Password is invalid,please retry.");
                }
                else
                {
                  return  RedirectToAction("Dashboard", "Dashboard");
                }
            }
            return View(model);
        }
    }
}