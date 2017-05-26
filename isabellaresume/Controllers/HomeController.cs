using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using isabellaresume.Entities;
using isabellaresume.Models;
using isabellaresume.Models.ViewModels;
using isabellaresume.Services.JsonFileReaderService;
using Newtonsoft.Json;

namespace isabellaresume.Controllers
{
    public class HomeController : Controller
    {
        private static Context _context;
        private static JsonFileReaderService _fileReaderService;

        public HomeController()
        {
            _context = new Context();
            _fileReaderService = new JsonFileReaderService();
            _context = _fileReaderService.ReadJsonFiles(_context);

        }
        public ActionResult Index()
        {
            var viewModel = PopulateViewModel();

            return View(viewModel);
        }

        private static IndexViewModel PopulateViewModel()
        {
            return new IndexViewModel()
            {
                Educations = TransformEducations(),
                WorkPlaces = TransformWorkplaces(),
                Projects = TransformProjects(),
                Courses = TransformCourses(),
                Languages = TransformLanguages()
            };
        }

        private static IEnumerable<WorkPlaceItem> TransformWorkplaces()
        {
            return _context.Workplaces.Select(s => new WorkPlaceItem()
            {
                End = s.End,
                Start = s.Start,
                Description = s.Description,
                CompanyName = s.CompanyName,
                Current = s.Current,
                LocationName = s.LocationName,
                Position = s.Position
            });
        }

        private static IEnumerable<EducationItem> TransformEducations()
        {
            return _context.Educations.Select(s => new EducationItem
            {
                LinkToEducation = s.LinkToEducation,
                FieldOfStudy = s.FieldOfStudy,
                End = s.End,
                Start = s.Start,
                Description = s.Description,
                DegreeName = s.DegreeName,
                SchoolName = s.SchoolName
            });
        }
        private static IEnumerable<LanguageItem> TransformLanguages()
        {
            return _context.Languages.Select(s => new LanguageItem()
            {
                LanguageName = s.LanguageName,
                Proficiency = s.Proficiency
            });
        }

        private static IEnumerable<CourseItem> TransformCourses()
        {
            return _context.Courses.Select(s => new CourseItem()
            {
                End = s.End,
                Start = s.Start,
                Description = s.Description,
                AssociatedEducation = s.AssociatedEducation,
                AssociatedWorkplace = s.AssociatedWorkplace,
                CourseName = s.CourseName
            });
        }

        private static IEnumerable<ProjectItem> TransformProjects()
        {
            return _context.Projects.Select(s => new ProjectItem()
            {
                End = s.End,
                Start = s.Start,
                Description = s.Description,
                AssociatedEducation = s.AssociatedEducation,
                AssociatedWorkplace = s.AssociatedWorkplace,
                Ongoing = s.Ongoing,
                ProjectName = s.ProjectName
            });
        }
    }
}