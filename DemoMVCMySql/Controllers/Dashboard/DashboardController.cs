using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVCMySql.Models;

namespace DemoMVCMySql.Controllers.Dashboard
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            List<StudentModel> Students = new KIPPDemoDAO().GetStudents();
            return View(Students);
        }
    }
}