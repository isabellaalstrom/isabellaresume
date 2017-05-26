using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using isabellaresume.Entities;
using isabellaresume.Models;
using isabellaresume.Models.ViewModels;
using isabellaresume.Services.JsonFileReaderService;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Context = isabellaresume.Entities.Context;

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
            viewModel.TimelineItems = GetAllItemsForTimeline(viewModel);
            return View(viewModel);
        }

        private static IndexViewModel PopulateViewModel()
        {
            return new IndexViewModel()
            {
                Educations = TransformEducations(),
                WorkPlaces = TransformWorkplaces(),
                //Projects = TransformProjects(),
                //Courses = TransformCourses(),
                Languages = TransformLanguages()
            };
        }

        private static IEnumerable<WorkPlaceItem> TransformWorkplaces()
        {
            DateTime startDate;
            DateTime endDate;
            return _context.Workplaces.Select(s => new WorkPlaceItem()
            {
                StartDate = DateTime.TryParse(s.StartDate, out startDate) ? startDate : DateTime.Now,
                EndDate = DateTime.TryParse(s.EndDate, out endDate) ? endDate : DateTime.Now,
                Description = s.Description,
                CompanyName = s.CompanyName,
                Ongoing = s.Current,
                LocationName = s.LocationName,
                Position = s.Position,
                Courses = s.Courses,
                Projects = s.Projects
            });
        }

        private static IEnumerable<EducationItem> TransformEducations()
        {
            DateTime startDate;
            DateTime endDate;
            return _context.Educations.Select(s => new EducationItem
            {
                LinkToEducation = s.LinkToEducation,
                FieldOfStudy = s.FieldOfStudy,
                StartDate = DateTime.TryParse(s.StartDate, out startDate) ? startDate : DateTime.Now,
                EndDate = DateTime.TryParse(s.EndDate, out endDate) ? endDate : DateTime.Now,
                Description = s.Description,
                DegreeName = s.DegreeName,
                SchoolName = s.SchoolName,
                Courses = s.Courses,
                Projects = s.Projects
                //todo add ongoing
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

        //private static IEnumerable<CourseItem> TransformCourses()
        //{
        //    DateTime startDate;
        //    DateTime endDate;
        //    return _context.Courses.Select(s => new CourseItem()
        //    {
        //        //StartDate = DateTime.TryParse(s.StartDate, out startDate) ? startDate : DateTime.Now,
        //        //EndDate = DateTime.TryParse(s.EndDate, out endDate) ? endDate : DateTime.Now,
        //        Description = s.Description,
        //        AssociatedEducation = s.AssociatedEducation,
        //        AssociatedWorkplace = s.AssociatedWorkplace,
        //        CourseName = s.CourseName
        //    });
        //}

        //private static IEnumerable<ProjectItem> TransformProjects()
        //{
        //    DateTime startDate;
        //    DateTime endDate;
        //    return _context.Projects.Select(s => new ProjectItem()
        //    {
        //        //StartDate = DateTime.TryParse(s.StartDate, out startDate) ? startDate : DateTime.Now,
        //        //EndDate = DateTime.TryParse(s.EndDate, out endDate) ? endDate : DateTime.Now,
        //        Description = s.Description,
        //        AssociatedEducation = s.AssociatedEducation,
        //        AssociatedWorkplace = s.AssociatedWorkplace,
        //        Ongoing = s.Ongoing,
        //        ProjectName = s.ProjectName
        //    });
        //}
        private static IEnumerable<TimelineItem> GetAllItemsForTimeline(IndexViewModel vm)
        {
            var timelineItems = vm.WorkPlaces.Select(wp => new TimelineItem
            {
                Type = TypeEnum.workplace,
                Title = wp.Position,
                Name = wp.CompanyName,
                Description = wp.Description,
                StartDate = wp.StartDate,
                EndDate = wp.EndDate,
                Ongoing = wp.Ongoing,
                Location = wp.LocationName,
                Projects = wp.Projects,
                Courses = wp.Courses
            }).ToList();
            timelineItems.AddRange(vm.Educations.Select(e => new TimelineItem
            {
                Type = TypeEnum.education,
                Title = e.FieldOfStudy,
                Name = e.SchoolName,
                Description = e.Description,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                LinkToEducation = e.LinkToEducation,
                Courses = e.Courses,
                Projects = e.Projects
            }));
            //timelineItems.AddRange(vm.Courses.Select(c => new TimelineItem
            //{
            //    Type = TypeEnum.Course,
            //    Title = c.CourseName,
            //    Name = c.AssociatedEducation.IsNullOrWhiteSpace() ? c.AssociatedWorkplace : c.AssociatedEducation,
            //    Description = c.Description,
            //    StartDate = c.StartDate,
            //    EndDate = c.EndDate,
            //    AssociatedEducation = c.AssociatedEducation,
            //    AssociatedWorkplace = c.AssociatedWorkplace
            //}));
            //timelineItems.AddRange(vm.Projects.Select(p => new TimelineItem
            //{
            //    Type = TypeEnum.project,
            //    Title = p.ProjectName,
            //    Name = p.AssociatedEducation.IsNullOrWhiteSpace() ? p.AssociatedWorkplace : p.AssociatedEducation,

            //    Description = p.Description,
            //    StartDate = p.StartDate,
            //    EndDate = p.EndDate,
            //    AssociatedEducation = p.AssociatedEducation,
            //    AssociatedWorkplace = p.AssociatedWorkplace
            //}));
            return timelineItems.OrderByDescending(i => i.StartDate);
        }
    }
}