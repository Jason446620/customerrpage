using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customerrorpage.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult General(string msg)
        {
            ViewBag.Message = msg;

            return View();
        }
        public ActionResult HttpError404(string msg)
        {
            ViewBag.Message = msg;

            return View();
        }
        public ActionResult HttpError500(string msg)
        {
            ViewBag.Message = msg;

            return View();
        }
    }
}