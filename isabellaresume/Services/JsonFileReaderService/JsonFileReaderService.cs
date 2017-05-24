using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using isabellaresume.Models;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService
{
    public class JsonFileReaderService : IJsonFileReaderService
    {
        public IEnumerable<Education> ReadEducations()
        {
            try
            {
                using (StreamReader r = new StreamReader(GetFilePath("MusicGenres.json")))
                {
                    string json = r.ReadToEnd();
                    var educations = JsonConvert.DeserializeObject<IEnumerable<Education>>(json);

                    return educations;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Workplace ReadWorkplace()
        {
            throw new NotImplementedException();
        }

        public Language ReadLanguage()
        {
            throw new NotImplementedException();
        }

        public Course ReadCourse()
        {
            throw new NotImplementedException();
        }

        public Project ReadProject()
        {
            throw new NotImplementedException();
        }

        private static string GetFilePath(string fileName)
        {
            string filePath;

            try
            {
                filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "MusicRecommendation.Services", "JsonFiles", fileName);

                return filePath;
            }
            catch (Exception)
            {
                filePath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath.Replace("MusicRecommendation.Web", "MusicRecommendation.Services"), "JsonFiles", fileName);

                return filePath;
            }
        }
    }
}