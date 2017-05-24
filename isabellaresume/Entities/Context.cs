using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Context : IContext
    {
        //[JsonProperty("educations")]
        public IList<Education> Educations { get; set; }

        //[JsonProperty("workplaces")
        public IList<Workplace> Workplaces { get; set; }

        //[JsonProperty("courses")]
        public IList<Course> Courses { get; set; }

        //[JsonProperty("languages")]
        public IList<Language> Languages { get; set; }

        //[JsonProperty("projects")]
        public IList<Project> Projects { get; set; }
    }

    public interface IContext
    {
        
    }
}