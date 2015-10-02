using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVCMySql.Models;
using System.Data.Objects;
using System.Web.Helpers;

namespace DemoMVCMySql.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(ProfileModel model, string actionRequest)
        {

            if (model.UserID != null && model.UserID.Length > 0  && model.Password.Length > 0)
            {
                List<profile> profiles = new List<profile>();
                //Validate login

                using (var queryDB = new samsjacksonvilleEntities())
                {
                    profiles = queryDB.profiles.SqlQuery("select * from profile where UserID = @p0 and Password = @p1", model.UserID, model.Password).ToList();
                }

                
            }
            return View();

        }
    }
}