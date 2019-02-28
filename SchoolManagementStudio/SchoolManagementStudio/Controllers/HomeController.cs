using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using SchoolManagementStudio.Data;
using SchoolManagementStudio.Data.TableModels;

namespace SchoolManagementStudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            // My code
            // var context = new SchoolContext();
            // context.AddStudent();
            List<Course> courses = DataManagement.GetAllCourses();

            return View(courses);
        }


        // New Test Page
        public ViewResult TestPage() {

            List<Course> courses = DataManagement.GetAllCourses();

            return View(courses);
        }

    }

}
