using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.DAL.Repository;

namespace ISchool.Service.Services
{
    public class StudentService : EntityService, IStudentService
    {
        private Lazy<IStudentRepository> _studentRepository;
        public StudentService(IEntityRepository entityRepository, IStudentRepository studentRepository) : base(entityRepository)
        {
            _studentRepository = new Lazy<IStudentRepository>(() => studentRepository);
        }
    }
}
