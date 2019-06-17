using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Hello()
        {
            return "<html><body>Hello <b>World</b></body></html>";
        }
        public ActionResult MyFirstAction()
        {
            ViewBag.Data = 1234;
            ViewBag.SomeString = "abc";
            return View();
        }
        public ActionResult MySecondAction(int id=0, string data ="")
        {
            ViewBag.id = id;
            ViewBag.data = data;
            return View();
        }
    }
}