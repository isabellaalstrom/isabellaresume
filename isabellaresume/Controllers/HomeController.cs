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
            ReadEducations();
            var viewModel = new IndexViewModel()
            {
                //EducationItems = TransformEducations(ReadEducations())
            };

            return View();
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

        IEnumerable<EducationItem> TransformEducations(IEnumerable<Education> educations)
        {
            return educations.Select(s => new EducationItem { SchoolName = s.SchoolName,  });
        }

        public Education ReadEducations()
        {
            //try
            //{
                using (StreamReader r = new StreamReader("c:/users/isabella.alstrom/documents/visual studio 2015/Projects/isabellaresume/isabellaresume/JsonFiles/Swedish/educations.json"))
                {
                    string json = r.ReadToEnd();
                    var educations = JsonConvert.DeserializeObject<Education>(json);
                //todo måste göra en modell, en item och en "vanlig". kan inte serializera lista osv
                    return educations;
                }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
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