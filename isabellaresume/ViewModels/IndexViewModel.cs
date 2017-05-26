using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Entities;

namespace isabellaresume.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<EducationItem> Educations { get; set; }
        public IEnumerable<WorkPlaceItem> WorkPlaces { get; set; }
        public IEnumerable<CourseItem> Courses{ get; set; }
        public IEnumerable<ProjectItem> Projects { get; set; }
        public IEnumerable<LanguageItem> Languages { get; set; }
        //todo skills
    }
}