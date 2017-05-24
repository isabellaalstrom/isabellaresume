using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Workplace
    {
        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("locationname")]
        public string LocationName { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}