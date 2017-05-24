﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isabellaresume.Entities
{
    public class Education
    {
        public string SchoolName { get; set; }
        public string DegreeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FieldOfStudy { get; set; }
        public string Description { get; set; }
        public string LinkToEducation { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}