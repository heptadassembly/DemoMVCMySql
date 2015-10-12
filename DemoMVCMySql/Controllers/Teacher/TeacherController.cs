using DemoMVCMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCMySql.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Teacher()
        {

            List<TeacherModel> Teachers = new KIPPDemoDAO().GetTeachers();
            return View(Teachers);
           
        }

    }
}