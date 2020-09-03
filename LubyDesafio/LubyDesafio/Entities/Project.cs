using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Entities
{
    public class Project : EntityBase
    {
        public string Name { get; set; }

        protected Project()
        {

        }

        public Project(string name)
        {
            Name = name;

        }
    }
}
