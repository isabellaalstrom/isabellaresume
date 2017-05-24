using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("fieldofstudy")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linktoeducation")]
        public string LinkToEducation { get; set; }
        //public IEnumerable<Course> Courses { get; set; }
    }
}