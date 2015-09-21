using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Theater.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Repertory()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Building()
        {
            return View();
        }

        public ActionResult Afisha()
        {
            return View();
        }

        public ActionResult Partners()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        //Так как страница пока не существует, перенаправляем на страницу ошибки
        public ActionResult People()
        {
            return View("Building");
        }

        //Так как страница пока не существует, перенаправляем на страницу ошибки
        public ActionResult Reports()
        {
            return View("Building");
        }
    }
}