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
        IEnumerable<Education> ReadEducations();
        Workplace ReadWorkplace();
        Language ReadLanguage();
        Course ReadCourse();
        Project ReadProject();
    }
}