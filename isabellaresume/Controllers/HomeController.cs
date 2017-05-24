using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using isabellaresume.Entities;
using isabellaresume.Models.ViewModels;
using isabellaresume.Services.JsonFileReaderService.Models;
using Newtonsoft.Json;

namespace isabellaresume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ReadEducations();
            var viewModel = new IndexViewModel()
            {
                Educations = TransformEducations(ReadEducations())
            };

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        IEnumerable<Education> TransformEducations(EducationModel educations)
        {
                //todo måste göra en modell, en item och en "vanlig". kan inte serializera lista osv
            return educations.EducationItems.Select(s => new Education
            {
                SchoolName = s.SchoolName,
                FieldOfStudy = s.FieldOfStudy,
                DegreeName = s.DegreeName,
                Description = s.Description,
                Start = s.Start, End = s.End,
                LinkToEducation = s.LinkToEducation
            });
        }

        public EducationModel ReadEducations()
        {
            try
            {
                var filePath = "C:/Users/Isabella/Source/Repos/isabellaresume/isabellaresume/JsonFiles/Swedish/educations.json"; //todo GetFilePath() som hämtar path
                //var filePath = "c:/users/isabella.alstrom/documents/visual studio 2015/Projects/isabellaresume/isabellaresume/JsonFiles/Swedish/educations.json";
                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    var educations = JsonConvert.DeserializeObject<EducationModel>(json);
                    return educations;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private static string GetFilePath(string fileName)
        {
            string filePath;

            //try
            //{
                filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JsonFiles", "Swedish", fileName);

                return filePath;
            //}
            //catch (Exception)
            //{
            //    filePath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath.Replace("MusicRecommendation.Web", "MusicRecommendation.Services"), "JsonFiles", fileName);

            //    return filePath;
            //}
        }
    }
}