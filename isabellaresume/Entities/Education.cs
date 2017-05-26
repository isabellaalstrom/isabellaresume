using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Models;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Education
    {
        [JsonProperty("schoolname")]
        public string SchoolName { get; set; }

        [JsonProperty("degreename")]
        public string DegreeName { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("fieldofstudy")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linktoeducation")]
        public string LinkToEducation { get; set; }

        [JsonProperty("courses")]
        public IEnumerable<CourseItem> Courses { get; set; }

        [JsonProperty("projects")]
        public IEnumerable<ProjectItem> Projects { get; set; }
    }
}