﻿using System;
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

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }
}