using ISchool.DAL.Repository;
using ISchool.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.Service.Services
{
    public class EntityService : IEntityService
    {
        private readonly IEntityRepository _entityRepository;

        public EntityService(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public async Task<T> GetByIdAsync<T>(int entityId) where T : class, IEntity
        {
            return await _entityRepository.GetByIdAsync<T>(entityId);
        }

        public async Task<IEnumerable<T>> GetAllEntitiesAsync<T>() where T : class, IEntity
        {
            return await _entityRepository.GetAllEntitiesAsync<T>();
        }

        public async Task<T> RemoveEntityAsync<T>(int entityId) where T : class, IEntity
        {
            return await _entityRepository.RemoveEntityAsync<T>(entityId);
        }

        public async Task<IEnumerable<T>> GetAllEntitiesAsync<T>(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includes) where T : class, IEntity
        {
            return await _entityRepository.GetAllEntitiesAsync<T>(filter, orderBy, includes);
        }
    }
}
