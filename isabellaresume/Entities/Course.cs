using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Models;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Course
    {
        [JsonProperty("coursename")]
        public string CourseName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("associatededucation")]
        public string AssociatedEducation { get; set; }

        [JsonProperty("associatedworkplace")]
        public string AssociatedWorkplace { get; set; }

        //[JsonProperty("startdate")]
        //public string StartDate { get; set; }

        //[JsonProperty("enddate")]
        //public string EndDate { get; set; }
    }
}