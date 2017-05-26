using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isabellaresume.Models
{
    public class ProjectItem
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string AssociatedEducation { get; set; }
        public string AssociatedWorkplace { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        public bool Ongoing { get; set; }
    }
}