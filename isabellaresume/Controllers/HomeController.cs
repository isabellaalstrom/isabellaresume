using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using isabellaresume.Entities;
using isabellaresume.Models.ViewModels;
using isabellaresume.Services.JsonFileReaderService;
using isabellaresume.Services.JsonFileReaderService.Models;
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
            ReadEducations();
            ReadWorkplaces();
            //_fileReaderService = new JsonFileReaderService();
            //_context = _fileReaderService.ReadJsonFiles(_context);

        }
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                Educations = TransformEducations(),
                WorkPlaces = TransformWorkplaces()
                
            };

            return View(viewModel);
        }

        private IEnumerable<WorkPlaceItem> TransformWorkplaces()
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

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        IEnumerable<EducationItem> TransformEducations()
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

        private void ReadEducations()
        {
            try
            {
                var filePath = GetFilePath("educations");

                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    _context.Educations = JsonConvert.DeserializeObject<List<Education>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ReadWorkplaces()
        {
            try
            {
                var filePath = GetFilePath("workplaces");

                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    _context.Workplaces = JsonConvert.DeserializeObject<List<Workplace>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private static string GetFilePath(string fileName)
        //todo GetFilePath() som hämtar path
        {
            return $"C:/Users/Isabella/Source/Repos/isabellaresume/isabellaresume/JsonFiles/Swedish/{fileName}.json";
        }
    }
}