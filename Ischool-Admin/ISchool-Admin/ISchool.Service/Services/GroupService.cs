using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.DAL.Repository;

namespace ISchool.Service.Services
{
    public class GroupService : EntityService, IGroupService
    {
        private Lazy<IGroupRepository> _groupRepository;
        public GroupService(IEntityRepository entityRepository, IGroupRepository groupRepository) : base(entityRepository)
        {
            _groupRepository = new Lazy<IGroupRepository>(() => groupRepository);
        }
    }
}
