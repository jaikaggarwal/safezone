using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthForm.ViewModels;

namespace HealthForm.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
    
            return View();
        }

        [HttpPost]
        public ActionResult Create(RandomPatientViewModel rpvm)
        {
            string[] selected;
            try
            {
                selected = Request.Form["ethnicity"].Split(',');
                foreach (var num in selected)
                {
                    rpvm.Patient.Ethnicity.Add(Int32.Parse(num));

                }
            } catch (NullReferenceException e)
            {
                rpvm.Patient.Ethnicity.Add(-1);
            }


            return RedirectToAction("Index", "Result");
        }
    }
}