using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using isabellaresume.Entities;
using isabellaresume.Models.ViewModels;

namespace isabellaresume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                Educations = TransformEducations(ReadEducations)
                //samma sak här typ
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

        IEnumerable<EducationsItem> TransformEducations(IEnumerable<Education> educations)
        {
            return educations.Select(s => new EducationsItem { myProp = s.myProp, myProp2 = s.myProp2 })
            }
    }
}