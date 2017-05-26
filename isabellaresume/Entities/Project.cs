using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Project
    {
        [JsonProperty("projectname")]
        public string ProjectName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("associatededucation")]
        public string AssociatedEducation { get; set; }

        [JsonProperty("associatedworkplace")]
        public string AssociatedWorkplace { get; set; }

        //[JsonProperty("start")]
        //public string StartDate { get; set; }

        //[JsonProperty("end")]
        //public string EndDate { get; set; }

        [JsonProperty("ongoing")]
        public bool Ongoing { get; set; }
    }
}