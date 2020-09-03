using LubyDesafio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Data.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class ,  IEntity
    {
        
            IEnumerable<TEntity> GetAll();
            TEntity GetById(Guid id);
            void Add(TEntity entity);
            void Update(TEntity entity);
            void Delete(Guid id);
            int SaveChanges();
        
    
    }
}
