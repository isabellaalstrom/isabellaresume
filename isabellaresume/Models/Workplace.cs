using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isabellaresume.Models
{
    public class Workplace
    {
        public string CompanyName { get; set; }
        public string LocationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Current { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
    }
}