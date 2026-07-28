using ConfigurationExample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder
             .Property(c => c.Name)
             .HasColumnType("VARCHAR(100)")
             .IsRequired();

            builder
                .HasIndex(c => c.Name)
                .IsUnique();

        }
    }
}
