using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isabellaresume.Entities;
using isabellaresume.Models;

namespace isabellaresume.Services.JsonFileReaderService
{
    public interface IJsonFileReaderService
    {
        Context ReadJsonFiles(Context context);
        void ReadEducations();
        void ReadWorkplaces();
        void ReadLanguages();
        void ReadCourses();
        void ReadProjects();
    }
}