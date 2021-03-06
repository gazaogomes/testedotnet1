﻿using LubyDesafio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Data.Mappings
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name).IsRequired().HasMaxLength(60);

            
        }
    }
}
