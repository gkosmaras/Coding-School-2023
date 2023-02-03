﻿using EF.Course.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Course.ORM.Configurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todo");
            builder.HasKey(todo => todo.ID);
            builder.Property(todo => todo.ID).ValueGeneratedOnAdd();
            builder.Property(todo => todo.Title).HasMaxLength(50).IsRequired(true);
        }
    }
}