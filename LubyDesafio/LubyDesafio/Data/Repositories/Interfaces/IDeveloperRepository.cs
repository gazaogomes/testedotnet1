using LubyDesafio.Entidades;
using System.Collections.Generic;

namespace LubyDesafio.Data.Repositories.Interfaces
{
    public interface IDeveloperRepository : IRepository<Developer>
    {
        List<Developer> GetAllWithHours();
    }
}
