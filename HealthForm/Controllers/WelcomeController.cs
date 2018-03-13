using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthForm.Models;

namespace HealthForm.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(User user)
        {
            return RedirectToAction("Index", "Dashboard");

        }
    }
}