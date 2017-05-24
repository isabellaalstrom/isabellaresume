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
        public string AssociatedEducation { get; set; }
        public string AssociatedWorkplace { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}