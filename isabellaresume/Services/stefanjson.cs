//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.Hosting;
//using Newtonsoft.Json;

//namespace isabellaresume.Services
//{
//    public interface IJsonFileReaderService
//    {
//        GenreModel ReadGenres();
//        ArtistModel ReadArtists();
//    }

//    public class JsonFileReaderService : IJsonFileReaderService
//    {
//        public GenreModel ReadGenres()
//        {
//            try
//            {
//                using (StreamReader r = new StreamReader(GetFilePath("MusicGenres.json")))
//                {
//                    string json = r.ReadToEnd();
//                    var genreModel = JsonConvert.DeserializeObject<GenreModel>(json);

//                    return genreModel;
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                throw;
//            }
//        }

//        public ArtistModel ReadArtists()
//        {
//            try
//            {
//                using (StreamReader r = new StreamReader(GetFilePath("MusicArtists.json")))
//                {
//                    string json = r.ReadToEnd();
//                    var artistModel = JsonConvert.DeserializeObject<ArtistModel>(json);

//                    return artistModel;
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                throw;
//            }
//        }

//        private static string GetFilePath(string fileName)
//        {
//            string filePath;

//            try
//            {
//                filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "MusicRecommendation.Services", "JsonFiles", fileName);

//                return filePath;
//            }
//            catch (Exception)
//            {
//                filePath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath.Replace("MusicRecommendation.Web", "MusicRecommendation.Services"), "JsonFiles", fileName);

//                return filePath;
//            }
//        }
//    }
//}