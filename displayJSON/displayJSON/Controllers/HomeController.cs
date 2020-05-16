using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using displayJSON.Models;

namespace displayJSON.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult EmpDetails()
        {
            List<Employee> ObjEmp = new List<Employee>();

            {
                new Employee { Id = 1, Name = "Alvaro Castro", City = "Los Angeles, CA" };
                new Employee { Id = 2, Name = "Julio Bashemore", City = "Chicago, IL" };
            }

            //return list as Json

            return Json(ObjEmp, JsonRequestBehavior.AllowGet);
        }
    }
}
