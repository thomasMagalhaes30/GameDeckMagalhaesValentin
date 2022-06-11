using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDeckWebApplication.Controllers
{
    public class JeuController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}