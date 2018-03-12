using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HealthForm.Models;

namespace HealthForm.ViewModels
{
    public class RandomPatientViewModel
    {
        public Patient Patient { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Location> Locations { get; set; }
    }
}