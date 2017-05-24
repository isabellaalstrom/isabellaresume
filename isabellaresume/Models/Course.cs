using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isabellaresume.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public Education AssociatedEducation { get; set; }
        public Workplace AssociatedWorkplace { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}