using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using isabellaresume.Entities;

namespace isabellaresume.Models
{
    public class EducationItem
    {
        public string SchoolName { get; set; }
        public string DegreeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FieldOfStudy { get; set; }
        public bool Ongoing { get; set; }
        public string Description { get; set; }
        public string LinkToEducation { get; set; }
        public IEnumerable<CourseItem> Courses { get; set; }
        public IEnumerable<ProjectItem> Projects { get; set; }
    }
}