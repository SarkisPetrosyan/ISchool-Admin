using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.DAL.Repository;

namespace ISchool.Service.Services
{
    public class LessonService : EntityService, ILessonService
    {
        private Lazy<ILessonRepository> _lessonRepository;
        public LessonService(IEntityRepository entityRepository, ILessonRepository lessonRepository) : base(entityRepository)
        {
            _lessonRepository = new Lazy<ILessonRepository>(() => lessonRepository);
        }
    }
}
