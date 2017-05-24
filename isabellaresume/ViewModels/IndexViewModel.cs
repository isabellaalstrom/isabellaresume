using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using isabellaresume.Entities;
using isabellaresume.Services.JsonFileReaderService.Models;

namespace isabellaresume.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<EducationItem> Educations { get; set; }
        public IEnumerable<WorkPlaceItem> WorkPlaces { get; set; }
        //todo ladda in all info från alla andra klasser i listor
    }
}