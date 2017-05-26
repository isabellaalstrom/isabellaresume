using System;
using System.Collections.Generic;

namespace isabellaresume.Models
{
    public class WorkPlaceItem
    {
        public string CompanyName { get; set; }
        public string LocationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Ongoing { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public IEnumerable<CourseItem> Courses { get; set; }
        public IEnumerable<ProjectItem> Projects { get; set; }
    }
}