using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Entities;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService.Models
{
    public class Education
    {
        [JsonProperty("schoolname")]
        public string SchoolName { get; set; }
        [JsonProperty("degreename")]
        public string DegreeName { get; set; }
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("end")]
        public DateTime End { get; set; }
        [JsonProperty("fieldofstudy")]
        public string FieldOfStudy { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("linktoeducation")]
        public string LinkToEducation { get; set; }
        //public IEnumerable<Course> Courses { get; set; }
    }
}