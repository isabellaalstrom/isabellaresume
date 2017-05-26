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
        public string Start { get; set; }
        public string End { get; set; }
        public bool Ongoing { get; set; }
    }
}