using LubyDesafio.Data.Context;
using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LubyDesafio.Data.Repositories
{
    public class DeveloperRepository : RepositoryBase<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(LubyDesafioContext contexto) : base(contexto)
        {
        }

        public List<Developer> GetAllWithHours()
        {
           return _dbSet.Include(x => x.TimeEntries).ToList();
        }
    }
}
