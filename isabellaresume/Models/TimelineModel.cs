using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization.Configuration;
using isabellaresume.Entities;

namespace isabellaresume.Models
{
    public class TimelineItem
    {
        public TypeEnum Type { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FieldOfStudy { get; set; }
        public string LinkToEducation { get; set; }
        public bool Ongoing { get; set; }
        public string Location { get; set; }
        public IEnumerable<CourseItem> Courses { get; set; }
        public IEnumerable<ProjectItem> Projects { get; set; }
    }

    public enum TypeEnum
    {
        education,
        workplace,
        project,
        course
    }
}