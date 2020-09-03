using LubyDesafio.Data.Context;
using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entities;

namespace LubyDesafio.Data.Repositories
{
    public class TimeEntryRepository : RepositoryBase<TimeEntry>, ITimeEntryRepository
    {
        public TimeEntryRepository(LubyDesafioContext contexto) : base(contexto)
        {
        }
    }
}
