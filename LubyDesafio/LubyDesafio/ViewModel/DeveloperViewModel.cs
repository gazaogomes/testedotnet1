using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.ViewModel
{
    public class DeveloperViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string LinkedinURL { get; set; }
    }
}
