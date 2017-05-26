using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isabellaresume.Models
{
    public class CourseItem
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string AssociatedEducation { get; set; }
        public string AssociatedWorkplace { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}