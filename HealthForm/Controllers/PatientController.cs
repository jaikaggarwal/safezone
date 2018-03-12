using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthForm.Models;
using HealthForm.ViewModels;

namespace HealthForm.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {

            return Content("This a patient");

        }

        public ActionResult Random(int? id)
        {
            Patient patient;
            var doctors = new List<Doctor>
            {
                new Doctor { age = 50 },
                new Doctor { age = 30 }
            };


            if (id.HasValue)
            {

                patient = new Patient() { FirstName = "Raj", ID = id.ToString() };

            
            } else { 
                patient = new Patient() { FirstName = "Raj" };
            }

            var viewModel = new RandomPatientViewModel
            {
                Patient = patient,
                Doctors = doctors
            };

            return View(viewModel);
        }

        public ActionResult ByID(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult New()
        {
            return View();
        }
    }
}