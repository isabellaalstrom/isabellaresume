using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isabellaresume.Entities;
using isabellaresume.Models;
using isabellaresume.Services.JsonFileReaderService.Models;

namespace isabellaresume.Services.JsonFileReaderService
{
    public interface IJsonFileReaderService
    {
        Context ReadJsonFiles(Context context);
        Context ReadEducations(Context context);
        Context ReadWorkplaces(Context context);
        //Context ReadLanguages(Context context);
        //Context ReadCourses(Context context);
        //Context ReadProjects(Context context);
    }
}