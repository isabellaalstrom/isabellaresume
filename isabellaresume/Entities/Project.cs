using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isabellaresume.Entities
{
    public class Project
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