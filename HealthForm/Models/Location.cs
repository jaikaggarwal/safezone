﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthForm.Models
{
    public class Location
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool selected { get; set; }
    }
}