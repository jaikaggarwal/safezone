using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthForm.Models
{
    public class Patient
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "I identify my sex as:")]
        public char Gender { get; set; }

        [Display(Name = "Select the ethnicities you identify with:")]
        public List<int> Ethnicity = new List<int>();

        [Required]
        [Display(Name = "The highest level of education I attained is:")]
        public int Education { get; set; }

        [Required]
        public List<int> MINIScore { get; set; }

        public string ID { get; set; }

        [Required]
        public Location Location { get; set; }
    }
}