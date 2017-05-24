using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService.Models
{
    public class WorkPlaceItem
    {
        public string CompanyName { get; set; }
        public string LocationName { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public bool Current { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
    }
}