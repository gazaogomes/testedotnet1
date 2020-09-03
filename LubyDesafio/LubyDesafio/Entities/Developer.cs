using LubyDesafio.Entities;
using System.Collections.Generic;

namespace LubyDesafio.Entidades
{
    public class Developer : EntityBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<TimeEntry> TimeEntries { get; set; }

        public string LinkedinURL { get; set; }

        protected Developer()
        {
                
        }
        public Developer(string name, int age, string linkedinURL)
        {
            Name = name;
            Age = age;
            LinkedinURL = linkedinURL;
        }
    }
}
