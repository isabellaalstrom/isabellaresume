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
        public Education AssociatedEducation { get; set; }
        public Workplace AssociatedWorkplace { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Ongoing { get; set; }
    }
}