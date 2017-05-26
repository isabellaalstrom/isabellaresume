using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Models;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Workplace
    {
        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("locationname")]
        public string LocationName { get; set; }

        [JsonProperty("startdate")]
        public string StartDate { get; set; }

        [JsonProperty("enddate")]
        public string EndDate { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("courses")]
        public IEnumerable<CourseItem> Courses { get; set; }

        [JsonProperty("projects")]
        public IEnumerable<ProjectItem> Projects { get; set; }
    }
}