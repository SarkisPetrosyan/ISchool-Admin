using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.DAL.Repository;

namespace ISchool.Service.Services
{
    public class TeacherService : EntityService, ITeacherService
    {
        private Lazy<ITeacherRepository> _teacherRepository;
        public TeacherService(IEntityRepository entityRepository, ITeacherRepository teacherRepository) : base(entityRepository)
        {
            _teacherRepository = new Lazy<ITeacherRepository>(() => teacherRepository);
        }
    }
}
