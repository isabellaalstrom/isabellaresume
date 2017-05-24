using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using isabellaresume.Entities;
using isabellaresume.Models;
using isabellaresume.Services.JsonFileReaderService.Models;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService
{
    public class JsonFileReaderService
    {
        private static Context _context;
        public Context ReadJsonFiles(Context context)
        {
            _context = context;
            ReadEducations();
            ReadWorkplaces();
            return _context;
        }

        public void ReadEducations()
        {
            try
            {
                var filePath = GetFilePath("educations");

                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    _context = JsonConvert.DeserializeObject<Context>(json);
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
                    _context = JsonConvert.DeserializeObject<Context>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //public Context ReadLanguages(Context context)
        //{
        //    throw new NotImplementedException();
        //}

        //public Context ReadCourses(Context context)
        //{
        //    throw new NotImplementedException();
        //}

        //public Context ReadProjects(Context context)
        //{
        //    throw new NotImplementedException();
        //}

        private static string GetFilePath(string fileName)
        //todo GetFilePath() som hämtar path
        {
            return $"C:/Users/Isabella/Source/Repos/isabellaresume/isabellaresume/JsonFiles/Swedish/{fileName}.json";
        }
    }
}