using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.DAL.Context;

namespace ISchool.DAL.Repository
{
    public class TeacherRepository : EntityRepository, ITeacherRepository
    {
        public TeacherRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
