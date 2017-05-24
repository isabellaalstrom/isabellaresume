using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService.Models
{
    public class EducationModel
    {
        [JsonProperty]
        public IEnumerable<EducationItem> EducationItems { get; set; }
    }

    public class EducationItem
    {
        
    }
}