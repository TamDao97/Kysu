using Kysu.DAL.DuLich.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kysu.Service.DuLich.Generic
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        public readonly IGenericRepository<TEntity> _iGenericRepository;
        public GenericService(IGenericRepository<TEntity> iGenericRepository)
        {
            _iGenericRepository = iGenericRepository;
        }

        public async Task Delete(TEntity entity)
        {
            await _iGenericRepository.Delete(entity);
        }

        public async Task Delete(object id)
        {
            await _iGenericRepository.Delete(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            return await _iGenericRepository.GetAll(filter, orderBy, includeProperties);
        }

        public async Task<TEntity> GetByID(object id)
        {
            return await _iGenericRepository.GetByID(id);
        }

        public async Task Insert(TEntity entity)
        {
            await _iGenericRepository.Insert(entity);
        }

        public async Task Update(TEntity entity)
        {
            await _iGenericRepository.Update(entity);
        }
    }
}
