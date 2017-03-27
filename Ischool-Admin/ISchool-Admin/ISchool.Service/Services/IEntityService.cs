using ISchool.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.Service.Services
{
    public interface IEntityService
    {
        Task<T> GetByIdAsync<T>(int entityId) where T : class, IEntity;
        Task<IEnumerable<T>> GetAllEntitiesAsync<T>() where T : class, IEntity;
        Task<T> RemoveEntityAsync<T>(int entityId) where T : class, IEntity;

        Task<IEnumerable<T>> GetAllEntitiesAsync<T>(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes) where T : class, IEntity;
    }
}
