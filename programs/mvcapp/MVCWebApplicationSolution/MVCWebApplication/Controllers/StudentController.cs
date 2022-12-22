using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        /**
        public ActionResult Index()
        {
            return View();
        }
    **/
    public string Index()
        {
            return "Student Controller:Index";
        }
    }
}