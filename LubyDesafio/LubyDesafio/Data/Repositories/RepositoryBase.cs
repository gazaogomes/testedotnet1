using LubyDesafio.Data.Context;
using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LubyDesafio.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class , IEntity
    {
        protected readonly LubyDesafioContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public RepositoryBase(LubyDesafioContext  contexto)
        {
            _context = contexto;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
        }

        public void Delete(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id)) ;
            SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            SaveChanges();
        }

        public void Dispose() 
        {
            _context?.Dispose();
        }

        
    }



}
