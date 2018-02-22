using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Angular4DotNetMvc.Models
{
    public class CourseViewModel
    {
        [Required]
        [Display(Name="Number")]
        public string Number { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Instructor")]
        public string Instructor { get; set; }
    }
}