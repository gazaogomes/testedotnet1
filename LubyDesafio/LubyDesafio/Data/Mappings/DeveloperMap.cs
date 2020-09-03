using LubyDesafio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LubyDesafio.Data.Mappings
{
    public class DeveloperMap : IEntityTypeConfiguration<Developer>
    {
        public void Configure (EntityTypeBuilder<Developer> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Age).IsRequired().HasMaxLength(2);
            builder.Property(l => l.LinkedinURL).IsRequired();
            builder.HasMany(x => x.TimeEntries).WithOne(y => y.Developer);


        }
    }
}
