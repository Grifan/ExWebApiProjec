using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExWebApiProjec.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [Authorize]
        public string ViewRole()
        {
            return "Ваша роль: Администратор";
        }
    }
}
