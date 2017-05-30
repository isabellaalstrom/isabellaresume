using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Hosting;
using isabellaresume.Entities;
using isabellaresume.Models;
using Newtonsoft.Json;

namespace isabellaresume.Services.JsonFileReaderService
{
    public class JsonFileReaderService : IJsonFileReaderService
    {
        private static Context _context;
        public Context ReadJsonFiles(Context context)
        {
            _context = context;
            ReadEducations();
            ReadWorkplaces();
            ////ReadCourses();
            ReadLanguages();
            //ReadProjects();
            return _context;
        }

        public void ReadEducations()
        {
            try
            {
                //var filePath = GetFilePath("educations");
               
                //using (StreamReader r = new StreamReader(filePath))
                //{
                //    string json = r.ReadToEnd();
                //    _context.Educations = JsonConvert.DeserializeObject<List<Education>>(json);
                //}
                _context.Educations = JsonConvert.DeserializeObject<List<Education>>(GetServerResponse("educations"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private string GetServerResponse(string name)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create($"http://isabellaalstrom.se/Jsonfiles/swedish/{name}.json");
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            return responseFromServer;
        }

        public void ReadWorkplaces()
        {
            try
            {
                _context.Workplaces = JsonConvert.DeserializeObject<List<Workplace>>(GetServerResponse("workplaces"));
                //var filePath = GetFilePath("workplaces");

                //using (StreamReader r = new StreamReader(filePath))
                //{
                //    string json = r.ReadToEnd();
                //    _context.Workplaces = JsonConvert.DeserializeObject<List<Workplace>>(json);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ReadLanguages()
        {
            try
            {
                _context.Languages = JsonConvert.DeserializeObject<List<Language>>(GetServerResponse("languages"));
                //var filePath = GetFilePath("languages");

                //using (StreamReader r = new StreamReader(filePath))
                //{
                //    string json = r.ReadToEnd();
                //    _context.Languages = JsonConvert.DeserializeObject<List<Language>>(json);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //public void ReadCourses()
        //{
        //    try
        //    {
        //        var filePath = GetFilePath("courses");

        //        using (StreamReader r = new StreamReader(filePath))
        //        {
        //            string json = r.ReadToEnd();
        //            _context.Courses = JsonConvert.DeserializeObject<List<Course>>(json);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //public void ReadProjects()
        //{
        //    try
        //    {
        //        var filePath = GetFilePath("projects");

        //        using (StreamReader r = new StreamReader(filePath))
        //        {
        //            string json = r.ReadToEnd();
        //            _context.Projects = JsonConvert.DeserializeObject<List<Project>>(json);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //private static string GetFilePath(string fileName)
        ////todo hämta path automatiskt
        //{
        //    fileName = fileName + ".json";
        //    string filePath;

        //    try
        //    {
        //        filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "isabellaresume", "JsonFiles", "Swedish", fileName);

        //        return filePath;
        //    }
        //    catch (Exception)
        //    {
        //        filePath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath.Replace("isabellaresume", "isabellaresume"), "JsonFiles", "Swedish", fileName);

        //        return filePath;
        //    }
        //}
    }
}