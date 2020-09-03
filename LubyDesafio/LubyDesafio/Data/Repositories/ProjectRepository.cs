using LubyDesafio.Data.Context;
using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entities;

namespace LubyDesafio.Data.Repositories
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(LubyDesafioContext contexto) : base(contexto)
        {
        }
    }
}
