using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Singleton.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var obj = Singleton.GetInstance(1);
            var obj2 = Singleton.GetInstance(2);

            ViewBag.Singleton = "instance1 ="+ obj.id+"  "+ "instance2 =" + obj2.id; 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}