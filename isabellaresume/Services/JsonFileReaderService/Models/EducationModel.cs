﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Entities;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService.Models
{
    public class EducationItem
    {
        public string SchoolName { get; set; }
        public string DegreeName { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string FieldOfStudy { get; set; }
        public string Description { get; set; }
        public string LinkToEducation { get; set; }
        //public IEnumerable<Course> Courses { get; set; }
    }
}