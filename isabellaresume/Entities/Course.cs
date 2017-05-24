using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Models;

namespace isabellaresume.Entities
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public EducationItem AssociatedEducation { get; set; }
        public Workplace AssociatedWorkplace { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}