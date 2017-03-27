using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.DAL.Context;

namespace ISchool.DAL.Repository
{
    public class StudentRepository : EntityRepository , IStudentRepository
    {
        public StudentRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
